using System;
using System.Collections.Generic;
using System.Text;

namespace CrashReporter
{
    /// <summary>
    /// Action to take when an unhandled exception is caught.
    /// </summary>
    public enum UnhandledExceptionBehavior
    {
        /// <summary>
        /// Immediately shutdown the application.
        /// </summary>
        Shutdown,
        /// <summary>
        /// Continue the running application.
        /// </summary>
        Continue
    }
}
