using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Management;
using System.Reflection;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CrashReporter
{
    /// <summary>
    /// Processes and reports exceptions.
    /// </summary>
    public static class Reporter
    {
        private static List<ExceptionFormatter> _exceptionFormatters = new List<ExceptionFormatter>();

        internal const string KeyEmailAddress = "E-mail address";

        /// <summary>
        /// Gets the current configuration of Crash Reporter.
        /// </summary>
        public static IConfiguration Configuration { get; private set; }
        /// <summary>
        /// Gets the system information used by Crash Reporter when
        /// sending reports.
        /// </summary>
        public static SystemInformation SystemInformation { get; private set; }

        /// <summary>
        /// Sets the configuration used when sending reports.
        /// </summary>
        /// <param name="configuration">Configuration used when sending reports.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="configuration"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when a configuration has already been provided.</exception>
        /// <exception cref="ArgumentException">Thrown when either the Url or Version haven't been set on the configuration.</exception>
        public static void SetConfiguration(IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException("configuration");

            if (Configuration != null)
                throw new InvalidOperationException(Properties.Resources.ConfigurationAlreadyProvided);

            if (configuration.Url == null)
                throw new ArgumentException(Properties.Resources.UrlIsRequired, "configuration");
            if (configuration.Version == null)
                throw new ArgumentException(Properties.Resources.VersionIsRequired, "configuration");

            Configuration = new FrozenConfiguration(configuration);

            // Once we have a valid configuration, we can set/update the system
            // information.

            using (var key = BaseKey)
            {
                SystemInformation = new SystemInformation(key);
            }
        }

        /// <summary>
        /// Unhandled exception handler. Use this method as an event handler
        /// for <see cref="AppDomain.UnhandledException"/> on <see cref="AppDomain.CurrentDomain"/>.
        /// </summary>
        /// <example>
        /// This example shows how to apply the event handler:
        /// <code>
        /// AppDomain.CurrentDomain.UnhandledException += Reporter.UnhandledExceptionHandler;
        /// </code>
        /// </example>
        /// <param name="sender">The source of the unhandled exception.</param>
        /// <param name="e">An <see cref="UnhandledExceptionEventArgs"/> that contains the event data.</param>
        public static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;

            // Can't handle non Exception exceptions.

            if (ex != null)
            {
                Report(ex);

                if (Configuration.UnhandledExceptionBehavior == UnhandledExceptionBehavior.Shutdown)
                    Environment.Exit(0);
            }
        }

        /// <summary>
        /// Unhandled thread exception handler. Use this method as an event handler
        /// for <see cref="Application.ThreadException"/>.
        /// </summary>
        /// <example>
        /// This example shows how to apply the event handler:
        /// <code>
        /// Application.ThreadException += Reporter.ThreadExceptionHandler;
        /// </code>
        /// </example>
        /// <param name="sender">The source of the thread exception.</param>
        /// <param name="e">An <see cref="ThreadExceptionEventArgs"/> that contains the event data.</param>
        public static void ThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            Report(e.Exception);

            if (Configuration.UnhandledExceptionBehavior == UnhandledExceptionBehavior.Shutdown)
                Environment.Exit(0);
        }

        internal static RegistryKey BaseKey
        {
            get
            {
                return Registry.CurrentUser.CreateSubKey(
                    "Software\\CrashReporter.NET\\" + Configuration.Application
                );
            }
        }

        /// <summary>
        /// Reports an exception. When called directly, this can be used in a
        /// try/catch statement.
        /// </summary>
        /// <example>
        /// This example shows how to report an exception.
        /// <code>
        /// try
        /// {
        ///     // Will throw a devide by zero exception.
        /// 
        ///     int i = 0;
        ///     int j = 1 / i;
        /// }
        /// catch (DivideByZeroException ex)
        /// {
        ///     Reporter.Report(ex);
        /// }
        /// </code>
        /// </example>
        /// <param name="exception">Exception to report.</param>
        public static void Report(Exception exception)
        {
            if (exception == null)
                throw new ArgumentNullException("exception");

            VerifyConfiguration();

            if (Configuration.ShowUI)
            {
                if (Configuration.DialogType == ExceptionDialogType.Technical)
                {
                    using (var form = new TechnicalExceptionForm())
                    {
                        form.Exception = exception;
                        form.ShowDialog();
                    }
                }
                else
                {
                    using (var form = new GenericExceptionForm())
                    {
                        form.Exception = exception;
                        form.ShowDialog();
                    }
                }
            }
            else if (Configuration.AlwaysSubmit)
            {
                string emailAddress;

                using (var key = BaseKey)
                {
                    emailAddress = (string)key.GetValue(KeyEmailAddress);
                }

                PerformSubmitException(exception, emailAddress, null, null);
            }
        }

        internal static void SendReport(IWin32Window owner, Exception exception)
        {
            if (Configuration.AllowEmailAddress || Configuration.AllowComments)
            {
                using (var form = new ReportForm())
                {
                    form.Exception = exception;
                    form.ShowDialog(owner);
                }
            }
        }

        internal static void SubmitException(IWin32Window owner, Exception exception, string emailAddress, string comments)
        {
            if (Configuration.ShowUI)
            {
                using (var form = new SendForm())
                {
                    form.Shown += (s, e) =>
                    {
                        ThreadPool.QueueUserWorkItem(p =>
                        {
                            PerformSubmitException(exception, emailAddress, comments, form.UpdateProgress);

                            form.Invoke(new Action(form.Dispose));
                        });
                    };

                    form.ShowDialog();
                }
            }
            else
            {
                PerformSubmitException(exception, emailAddress, comments, null);
            }
        }

        private static void PerformSubmitException(Exception exception, string emailAddress, string comments, ProgressCallback progressCallback)
        {
            try
            {
                if (progressCallback != null)
                    progressCallback(Properties.Resources.Connecting, 1, 4);

                var request = WebRequest.Create(Configuration.Url);

                request.Method = "POST";
                request.ContentType = "text/xml";

                using (var stream = request.GetRequestStream())
                {
                    if (progressCallback != null)
                        progressCallback(Properties.Resources.SendingRequest, 2, 4);

                    using (var writer = new StreamWriter(stream))
                    {
                        writer.Write(BuildXml(exception, emailAddress, comments));
                    }
                }

                if (progressCallback != null)
                    progressCallback(Properties.Resources.GettingResponse, 3, 4);

                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        reader.ReadToEnd();
                    }
                }

                if (progressCallback != null)
                    progressCallback(Properties.Resources.Done, 4, 4);
            }
            catch (Exception ex)
            {
                string message = String.Format(
                    Properties.Resources.CouldNotSubmitException, ex.Message
                );

                if (Configuration.ShowUI)
                {
                    MessageBox.Show(
                        message,
                        Properties.Resources.CrashReporter,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            finally
            {
                using (var key = BaseKey)
                {
                    SystemInformation.UpdateLastReportDateTime(key);
                }
            }
        }

        private static string BuildXml(Exception exception, string emailAddress, string comments)
        {
            var sb = new StringBuilder();

            using (var writer = XmlWriter.Create(sb))
            {
                writer.WriteStartElement("crash");

                writer.WriteAttributeString("application", Configuration.Application.ToString());
                writer.WriteAttributeString("applicationVersion", Configuration.Version);
                writer.WriteAttributeString("uuid", Guid.NewGuid().ToString());
                writer.WriteAttributeString("platform", ".net");
                writer.WriteAttributeString("os", SystemInformation.OperatingSystem);
                writer.WriteAttributeString("osVersion", SystemInformation.OperationSystemVersion);
                writer.WriteAttributeString("cpu", SystemInformation.Cpu);
                writer.WriteAttributeString("cpuInfo", SystemInformation.CpuInformation);
                writer.WriteAttributeString("reason", "Exception");
                writer.WriteAttributeString("installation", SerializeDateTime(SystemInformation.InstallationDateTime));
                writer.WriteAttributeString("startup", SerializeDateTime(SystemInformation.LastStartupDateTime));
                writer.WriteAttributeString("thread", Thread.CurrentThread.Name);

                if (!String.IsNullOrEmpty(emailAddress))
                    writer.WriteAttributeString("emailAddress", emailAddress);
                if (!String.IsNullOrEmpty(comments))
                    writer.WriteAttributeString("comments", comments);

                if (SystemInformation.LastReportDateTime.HasValue)
                    writer.WriteAttributeString("lastReport", SerializeDateTime(SystemInformation.LastReportDateTime.Value));

                while (exception != null)
                {
                    writer.WriteStartElement("exception");

                    Assembly assembly;

                    if (exception.TargetSite != null)
                        assembly = exception.TargetSite.DeclaringType.Assembly;
                    else
                        assembly = Assembly.GetCallingAssembly();

                    writer.WriteAttributeString("exception", exception.GetType().FullName);
                    writer.WriteAttributeString("module", assembly.GetName().Name);
                    writer.WriteAttributeString("moduleVersion", assembly.GetName().Version.ToString());
                    writer.WriteAttributeString("message", exception.Message);
                    writer.WriteAttributeString("source", exception.Source);

                    if (exception.StackTrace != null)
                        writer.WriteString(exception.StackTrace);

                    writer.WriteEndElement();

                    exception = exception.InnerException;
                }

                writer.WriteEndElement();
            }

            return sb.ToString();
        }

        private static string SerializeDateTime(DateTime dateTime)
        {
            return new DateTimeOffset(dateTime, TimeZone.CurrentTimeZone.GetUtcOffset(dateTime)).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffzz'00'");
        }

        private static DateTime DeserializeDateTime(String dateTime)
        {
            return DateTimeOffset.ParseExact(dateTime, "o", CultureInfo.InvariantCulture).LocalDateTime;
        }

        private static void VerifyConfiguration()
        {
            if (Configuration == null)
                throw new ConfigurationAbsentException();
        }

        /// <summary>
        /// Adds a custom formatter used when presenting exception information
        /// to the user when using the technical exception dialog type.
        /// </summary>
        /// <param name="formatter"></param>
        public static void AddFormatter(ExceptionFormatter formatter)
        {
            lock (_exceptionFormatters)
            {
                _exceptionFormatters.Add(formatter);
            }
        }

        internal static string FormatException(Exception exception)
        {
            lock (_exceptionFormatters)
            {
                for (int i = _exceptionFormatters.Count - 1; i >= 0; i--)
                {
                    if (_exceptionFormatters[i].Type.IsAssignableFrom(exception.GetType()))
                        return _exceptionFormatters[i].Format(exception);
                }

                return String.Format("{0} ({1})", exception.Message.TrimEnd(), exception.GetType().FullName);
            }
        }
    }
}
