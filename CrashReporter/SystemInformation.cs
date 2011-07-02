// #define CACHE_SYSTEM_INFORMATION

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Management;
using System.Globalization;

namespace CrashReporter
{
    /// <summary>
    /// Provides access to system information used when reporting exceptions.
    /// </summary>
    public class SystemInformation
    {
        private const string KeyInstallation = "Installation";
        private const string KeyLastReport = "Last report";
        private const string KeyOperatingSystem = "Operating system";
        private const string KeyOperationSystemVersion = "Operating system version";
        private const string KeyCpu = "Cpu";
        private const string KeyCpuInformation = "Cpu information";

        internal SystemInformation(RegistryKey key)
        {
            bool loaded = false;

            LastStartupDateTime = DateTime.Now;

            try
            {
                if (key.GetValue(KeyInstallation) != null)
                {
                    InstallationDateTime = DateTime.ParseExact(
                        (string)key.GetValue(KeyInstallation), "O",
                        CultureInfo.InvariantCulture
                    );

                    string lastReportDate = (string)key.GetValue(KeyLastReport);

                    if (lastReportDate != null)
                    {
                        LastReportDateTime = DateTime.ParseExact(
                            lastReportDate, "O", CultureInfo.InvariantCulture
                        );
                    }

#if CACHE_SYSTEM_INFORMATION
                    OperatingSystem = (string)key.GetValue(KeyOperatingSystem);
                    OperationSystemVersion = (string)key.GetValue(KeyOperationSystemVersion);
                    Cpu = (string)key.GetValue(KeyCpu);
                    CpuInformation = (string)key.GetValue(KeyCpuInformation);
#endif

                    loaded = true;
                }
            }
            catch
            {
                // If we were unable to load the settings, initialize new settings.
            }

            if (!loaded)
            {
                Detect();

                key.SetValue(KeyInstallation, InstallationDateTime.ToString("O"));

                if (key.GetValue(KeyLastReport) != null)
                    key.DeleteValue(KeyLastReport);

#if CACHE_SYSTEM_INFORMATION
                key.SetValue(KeyOperatingSystem, OperatingSystem);
                key.SetValue(KeyOperationSystemVersion, OperationSystemVersion);
                key.SetValue(KeyCpu, Cpu);
                key.SetValue(KeyCpuInformation, CpuInformation);
#endif
            }

#if !CACHE_SYSTEM_INFORMATION
            DetectSystemInformation();
#endif
        }

        private void Detect()
        {
            InstallationDateTime = DateTime.Now;

#if CACHE_SYSTEM_INFORMATION
            DetectSystemInformation();
#endif
        }

        private void DetectSystemInformation()
        {
            OperatingSystem = GetOs();
            OperationSystemVersion = GetOsVersion();

            try
            {
                var cpuInfo = GetCpuInformation();

                switch ((ushort)cpuInfo["Architecture"])
                {
                    case 0: Cpu = "x86"; break;
                    case 1: Cpu = "MIPS"; break;
                    case 2: Cpu = "Alpha"; break;
                    case 3: Cpu = "PowerPC"; break;
                    case 6: Cpu = "Itanium"; break;
                    case 9: Cpu = "x64"; break;
                    default: Cpu = "Unknown"; break;
                }

                CpuInformation = (string)cpuInfo["Caption"];
            }
            catch
            {
                Cpu = "Unknown";
                CpuInformation = "Unknown";
            }
        }

        private string GetOs()
        {
            string versionString = Environment.OSVersion.VersionString;
            string version = Environment.OSVersion.Version.ToString();

            int pos = versionString.IndexOf(Environment.OSVersion.Version.ToString());

            if (pos == -1)
                pos = versionString.IndexOf(Environment.OSVersion.Version.ToString(3));

            if (pos >= 0)
                return versionString.Substring(0, pos).Trim();
            else
                return Environment.OSVersion.Platform.ToString();
        }

        private string GetOsVersion()
        {
            string versionString = Environment.OSVersion.VersionString;
            string version = Environment.OSVersion.Version.ToString();

            int pos = versionString.IndexOf(version);

            if (pos >= 0)
                return versionString.Substring(pos).Trim();
            else
            {
                if (!String.IsNullOrEmpty(Environment.OSVersion.ServicePack))
                    return Environment.OSVersion.Version.ToString(3) + " " + Environment.OSVersion.ServicePack;
                else
                    return Environment.OSVersion.Version.ToString();
            }
        }

        private ManagementObject GetCpuInformation()
        {
            var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject obj in searcher.Get())
            {
                return obj;
            }

            return null;
        }

        /// <summary>
        /// Gets the installation date of the product using Crash Reporter.
        /// </summary>
        public DateTime InstallationDateTime { get; private set; }
        /// <summary>
        /// Gets the last startup date of the product using Crash Reporter.
        /// </summary>
        public DateTime LastStartupDateTime { get; private set; }
        /// <summary>
        /// Gets the last date a report was processed.
        /// </summary>
        public DateTime? LastReportDateTime { get; private set; }
        /// <summary>
        /// Gets the operating system.
        /// </summary>
        public string OperatingSystem { get; private set; }
        /// <summary>
        /// Gets the version of the operation system.
        /// </summary>
        public string OperationSystemVersion { get; private set; }
        /// <summary>
        /// Gets the name of the CPU.
        /// </summary>
        public string Cpu { get; private set; }
        /// <summary>
        /// Gets information of the CPU.
        /// </summary>
        public string CpuInformation { get; private set; }

        internal void UpdateLastReportDateTime(RegistryKey key)
        {
            LastReportDateTime = DateTime.Now;

            key.SetValue(
                KeyLastReport,
                LastReportDateTime.HasValue ? LastReportDateTime.Value.ToString("O") : null
            );
        }
    }
}
