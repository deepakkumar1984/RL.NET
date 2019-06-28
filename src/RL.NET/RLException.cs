using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RL.NET
{
    public class RLException : Exception
    {
        public ErrorCode Code { get; set; }

        public RLException(ErrorCode code)
        {
            Code = code;
        }

        public RLException(ErrorCode code, string message) : base(message)
        {
            Code = code;
        }

        public RLException(ErrorCode code, string message, Exception innerException) : base(message, innerException)
        {
            Code = code;
        }

        protected RLException(ErrorCode code, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Code = code;
        }
    }
}
