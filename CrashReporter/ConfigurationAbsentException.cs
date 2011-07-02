using System;
using System.Collections.Generic;
using System.Text;

namespace CrashReporter
{
    /// <summary>
    /// The exception that is thrown when no configuration has been provided
    /// and an exception is reported.
    /// </summary>
    public class ConfigurationAbsentException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationAbsentException"/>
        /// class.
        /// </summary>
        public ConfigurationAbsentException()
            : base(Properties.Resources.ConfigurationAbsent)
        {
        }
    }
}
