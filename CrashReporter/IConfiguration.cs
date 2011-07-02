using System;
using System.Collections.Generic;
using System.Text;

namespace CrashReporter
{
    /// <summary>
    /// Specifies a set of values used as configuration for exception reporting.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets the Url used to report exceptions to. This is the full Url
        /// to the submit servlet of CrashCollector.
        /// </summary>
        string Url { get; }
        /// <summary>
        /// Gets the Guid of the application used to report exceptions for.
        /// </summary>
        Guid Application { get; }
        /// <summary>
        /// Gets the title of the application used to display messages to the
        /// user with.
        /// </summary>
        string ApplicationTitle { get; }
        /// <summary>
        /// Gets the version of the application used when reporting exceptions.
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Gets whether to show a user interface when reporting exceptions.
        /// </summary>
        bool ShowUI { get; }
        /// <summary>
        /// Gets whether to allow the user to add a comment to the
        /// exception report before it's repored.
        /// </summary>
        bool AllowComments { get; }
        /// <summary>
        /// Gets whether to allow the user to add an e-mail address to
        /// the exception report before it's reported.
        /// </summary>
        bool AllowEmailAddress { get; }
        /// <summary>
        /// Gets whether exceptions should always be submitted. When set
        /// to false, the user will be presented with a "Submit exception report"
        /// button.
        /// </summary>
        bool AlwaysSubmit { get; }
        /// <summary>
        /// Gets the dialog type to be shown to the user when an exception
        /// is being reported.
        /// </summary>
        ExceptionDialogType DialogType { get; }
        /// <summary>
        /// Gets the action to take when catching an unhandled exception.
        /// </summary>
        UnhandledExceptionBehavior UnhandledExceptionBehavior { get; }
    }
}
