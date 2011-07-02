using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CrashReporterTest
{
    public class SomeOperationFailedException : Exception
    {
        public SomeOperationFailedException()
        {
        }

        public SomeOperationFailedException(string message)
            : base(message)
        {
        }

        public SomeOperationFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected SomeOperationFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
