using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading;

namespace CrashReporter
{
    /// <summary>
    /// Specifies a set of values used as configuration for exception reporting.
    /// </summary>
    public sealed class Configuration : IConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            ShowUI = true;
            AllowComments = true;
            AllowEmailAddress = true;
            AlwaysSubmit = false;
            DialogType = ExceptionDialogType.Generic;
            UnhandledExceptionBehavior = UnhandledExceptionBehavior.Shutdown;
        }

        /// <summary>
        /// Gets or sets the Url used to report exceptions to. This is the full Url
        /// to the submit servlet of CrashCollector.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the Guid of the application used to report exceptions for.
        /// </summary>
        public Guid Application { get; set; }
        /// <summary>
        /// Gets or sets the title of the application used to display messages to the
        /// user with.
        /// </summary>
        public string ApplicationTitle { get; set; }
        /// <summary>
        /// Gets or sets the version of the application used when reporting exceptions.
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Gets or sets whether to show a user interface when reporting exceptions.
        /// </summary>
        public bool ShowUI { get; set; }
        /// <summary>
        /// Gets or sets whether to allow the user to add a comment to the
        /// exception report before it's repored.
        /// </summary>
        public bool AllowComments { get; set; }
        /// <summary>
        /// Gets or sets whether to allow the user to add an e-mail address to
        /// the exception report before it's reported.
        /// </summary>
        public bool AllowEmailAddress { get; set; }
        /// <summary>
        /// Gets or sets whether exceptions should always be submitted. When set
        /// to false, the user will be presented with a "Submit exception report"
        /// button.
        /// </summary>
        public bool AlwaysSubmit { get; set; }
        /// <summary>
        /// Gets or sets the dialog type to be shown to the user when an exception
        /// is being reported.
        /// </summary>
        public ExceptionDialogType DialogType { get; set; }
        /// <summary>
        /// Gets or sets the action to take when catching an unhandled exception.
        /// </summary>
        public UnhandledExceptionBehavior UnhandledExceptionBehavior { get; set; }
    }
}
