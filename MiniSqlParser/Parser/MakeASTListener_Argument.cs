using Antlr4.Runtime.Misc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser
{
    internal partial class MakeASTListener : MiniSqlParserBaseListener
    {
        public override void ExitExprArgument([NotNull] MiniSqlParserParser.ExprArgumentContext context)
        {
            var expr = (Expr)_stack.Pop();
            var node = new ExprArgument(expr);
            _stack.Push(node);
        }

        public override void ExitPredicateArgument([NotNull] MiniSqlParserParser.PredicateArgumentContext context)
        {
            var predicate = (Predicate)_stack.Pop();
            var node = new PredicateArgument(predicate);
            _stack.Push(node);
        }
    }
}
