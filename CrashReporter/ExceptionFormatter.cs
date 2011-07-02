using System;
using System.Collections.Generic;
using System.Text;

namespace CrashReporter
{
    /// <summary>
    /// Formatter for formatting exceptions.
    /// </summary>
    public abstract class ExceptionFormatter
    {
        abstract internal Type Type { get; }

        /// <summary>
        /// Formats an exception to a human readable string.
        /// </summary>
        /// <param name="exception">Exception to format.</param>
        /// <returns>Human readable string for the provided exception.</returns>
        abstract public string Format(Exception exception);
    }

    /// <summary>
    /// Formatter for formatting exceptions.
    /// </summary>
    /// <typeparam name="T">Type of exception this formatter supports.</typeparam>
    public class ExceptionFormatter<T> : ExceptionFormatter
    {
        private readonly ExceptionFormatterCallback _formatter;

        /// <summary>
        /// Initializes a new instance of <see cref="ExceptionFormatter{T}"/>
        /// with a formatter.
        /// </summary>
        /// <param name="formatter">Delegate used to format the exception with.</param>
        public ExceptionFormatter(ExceptionFormatterCallback formatter)
        {
            if (formatter == null)
                throw new ArgumentNullException("formatter");

            _formatter = formatter;
        }

        internal override Type Type
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// Formats an exception to a human readable string.
        /// </summary>
        /// <param name="exception">Exception to format.</param>
        /// <returns>Human readable string for the provided exception.</returns>
        public override string Format(Exception exception)
        {
            return _formatter(exception);
        }
    }

    /// <summary>
    /// Delegate for formatting an exception.
    /// </summary>
    /// <param name="exception">Exception to format.</param>
    /// <returns>Human readable string for the provided exception.</returns>
    public delegate string ExceptionFormatterCallback(Exception exception);
}
