using System;
using System.Collections.Generic;
using System.Text;

namespace CrashReporter
{
    internal class FrozenConfiguration : IConfiguration
    {
        public FrozenConfiguration(IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException("configuration");

            Url = configuration.Url;
            Application = configuration.Application;
            ApplicationTitle = configuration.ApplicationTitle;
            Version = configuration.Version;
            ShowUI = configuration.ShowUI;
            AllowComments = configuration.AllowComments;
            AllowEmailAddress = configuration.AllowEmailAddress;
            AlwaysSubmit = configuration.AlwaysSubmit;
            DialogType = configuration.DialogType;
            UnhandledExceptionBehavior = configuration.UnhandledExceptionBehavior;
        }

        public string Url { get; private set; }
        public Guid Application { get; private set; }
        public string ApplicationTitle { get; private set; }
        public string Version { get; private set; }
        public bool ShowUI { get; private set; }
        public bool AllowComments { get; private set; }
        public bool AllowEmailAddress { get; private set; }
        public bool AlwaysSubmit { get; private set; }
        public ExceptionDialogType DialogType { get; private set; }
        public UnhandledExceptionBehavior UnhandledExceptionBehavior { get; private set; }
    }
}
