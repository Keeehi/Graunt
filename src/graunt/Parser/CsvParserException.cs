using System;

namespace graunt
{
    [Serializable()]
    public class CsvParserException : System.Exception
    {
        public CsvParserException() : base() { }
        public CsvParserException(string message) : base(message) { }
        public CsvParserException(string message, System.Exception inner) : base(message, inner) { } 
        protected CsvParserException(System.Runtime.Serialization.SerializationInfo info,  System.Runtime.Serialization.StreamingContext context): base(info, context) { }
    }
}
