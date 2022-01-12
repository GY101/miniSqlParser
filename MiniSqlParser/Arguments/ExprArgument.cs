using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser
{
    public class ExprArgument : Argument
    {
        public ExprArgument(Expr expr) : base(expr)
        {
        }

        public override bool IsExpr => true;

        protected override void AcceptImp(IVisitor visitor)
        {
            visitor.VisitBefore(this);
            if (Node != null)
            { 
                Node.Accept(visitor); 
            }
            visitor.VisitAfter(this);
        }
    }
}
