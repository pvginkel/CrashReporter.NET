using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrashReporter;
using System.Reflection;

namespace CrashReporterDemo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Setup CrashReporter. The URL is that of CrashCollector running
            // with default settings from Eclipse.
            //
            // Ensure you create an application in CrashCollector and set the
            // correct GUID here.

            Reporter.SetConfiguration(new Configuration
            {
                Url = "http://localhost:8888/submit",
                Application = new Guid("00000000-0000-0000-0000-000000000000"),
                ApplicationTitle = "Crash Reporter Demo",
                Version = Assembly.GetEntryAssembly().GetName().Version.ToString(),
                DialogType = ExceptionDialogType.Technical,
            });

            AppDomain.CurrentDomain.UnhandledException += Reporter.UnhandledExceptionHandler;
            Application.ThreadException += Reporter.ThreadExceptionHandler;

            Application.Run(new MainForm());
        }
    }
}
