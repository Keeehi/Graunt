using System;

namespace graunt
{
    [Serializable()]
    public class GeneralException : System.Exception
    {
        public GeneralException() : base() { }
        public GeneralException(string message) : base(message) { }
        public GeneralException(string message, System.Exception inner) : base(message, inner) { } 
        protected GeneralException(System.Runtime.Serialization.SerializationInfo info,  System.Runtime.Serialization.StreamingContext context): base(info, context) { }
    }
}
