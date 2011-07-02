using System;
using System.Collections.Generic;
using System.Text;

namespace CrashReporter
{
    /// <summary>
    /// Type of exception dialog to present the user with when an exception
    /// is reported.
    /// </summary>
    public enum ExceptionDialogType
    {
        /// <summary>
        /// Technical dialog which shows the stack of exceptions and inner
        /// exceptions with their message and exception type.
        /// </summary>
        Technical,
        /// <summary>
        /// Generic error dialog without detaild information.
        /// </summary>
        Generic
    }
}
