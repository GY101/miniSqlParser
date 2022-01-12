using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser
{
    public class PredicateArgument : Argument
    {
        public PredicateArgument(Predicate predicate) : base(predicate)
        {
        }

        public override bool IsExpr => false;

        protected override void AcceptImp(IVisitor visitor)
        {
            visitor.VisitBefore(this);
            Node.Accept(visitor);
            visitor.VisitAfter(this);
        }
    }
}
