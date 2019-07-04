using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace restArbol.Excepciones
{
    public class ControlException : Exception
    {
        public ControlException()
        {
        }

        public ControlException(string message) : base(message)
        {
        }

        public ControlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ControlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}