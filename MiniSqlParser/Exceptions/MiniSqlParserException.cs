using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MiniSqlParser
{
    public abstract class MiniSqlParserException : Exception
    {
        protected MiniSqlParserException()
        {
        }

        protected MiniSqlParserException(string message) : base(message)
        {
        }

        protected MiniSqlParserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        protected MiniSqlParserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
