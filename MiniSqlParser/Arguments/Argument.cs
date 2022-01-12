using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser
{
    public abstract class Argument : Node
    {
        public Argument(INode node)
        {
            Node = node;
        }
        private INode _node;
        public INode Node
        {
            get => _node;
            set
            {
                _node = value;
                SetParent(value);
            }
        }
        public abstract bool IsExpr { get; }
    }
}
