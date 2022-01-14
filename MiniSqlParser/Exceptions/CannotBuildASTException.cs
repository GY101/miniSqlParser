using System;
using System.Runtime.Serialization;

namespace MiniSqlParser
{
    [Serializable]
    public class CannotBuildASTException : MiniSqlParserException
    {
        public CannotBuildASTException(string message)
          : base(message)
        {
        }

        public CannotBuildASTException(string message
                                     , Exception inner)
          : base(message, inner)
        {
        }

        public CannotBuildASTException(SerializationInfo info
                                     , StreamingContext context)
          : base(info, context)
        {
        }
    }
}
