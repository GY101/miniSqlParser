using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser
{ 
    public class Arguments : NodeCollections<Argument>
    {
        private Arguments(List<Argument> arguments)
        {
            prefixTerminalNodeCount = 0;
            suffiexTerminalNodeCount = 0;
            nodes = arguments;
            foreach (var e in arguments)
            {
                this.SetParent(e);
            }
        }

        public Arguments(params Argument[] arguments)
          : this(new List<Argument>())
        {
            this.Comments = new Comments();
            this.AddRange(arguments);
        }

        public Arguments(IEnumerable<Argument> arguments)
          : this(new List<Argument>())
        {
            this.Comments = new Comments();
            this.AddRange(arguments);
        }

        internal Arguments(List<Argument> arguments, Comments comments)
          : this(arguments)
        {
            this.Comments = comments;
        }

        protected override void AcceptImp(IVisitor visitor)
        {
            visitor.VisitBefore(this);
            if (nodes.Count > 0)
            {
                nodes[0].Accept(visitor);
            }
            int i;
            for (i = 1; i < nodes.Count; ++i)
            {
                visitor.VisitOnSeparator(this, 0, i - 1);
                nodes[i].Accept(visitor);
            }
            visitor.VisitAfter(this);
        }
    }
}
