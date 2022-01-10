using MiniSqlParser.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser.Visitors
{
    public class ColumnTableNameCheckVisitor : Visitor
    {
        private class Alias
        {
            private HashSet<string> _tableAlias = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            private HashSet<string> _columnTableName = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            private Alias _parentAlias;
            public Alias(Alias alias)
            {
                _parentAlias = alias;
            }
            public Alias()
            {
            }
            public bool AddTable(string table)
            {
                return _tableAlias.Add(table);
            }
            public bool AddColumn(string column)
            {
                return _columnTableName.Add(column);
            }
            public bool Check()
            {
                Check(this);
                return _columnTableName.Count > 0;
            }
            public void Check(Alias alias)
            {
                if (alias != null)
                {
                    _columnTableName.ExceptWith(alias._tableAlias);
                    if (_columnTableName.Count > 0)
                        Check(_parentAlias);
                }
            }
            public IEnumerable<string> UnKnowAlias => _columnTableName;
        }
        Stack<Alias> aliases = new Stack<Alias>();
        public override void Visit(Column column)
        {
            var alias = aliases.Peek();
            if (!string.IsNullOrWhiteSpace(column.TableAliasName))
            {
                alias.AddColumn(column.TableAliasName);
            }
        }
        public override void Visit(Table table)
        {
            var alias = aliases.Peek();
            alias.AddTable(table.Name);
            if (!string.IsNullOrWhiteSpace(table.AliasName))
            {
                alias.AddTable(table.AliasName);
            }
        }
        public override void VisitOnFrom(SingleQueryClause query, int offset)
        {
            var alias = aliases.Peek();
            AddTable(query.From, alias);
        }

        private static void AddTable(IFromSource from, Alias alias)
        {
            switch (from)
            {
                case AliasedQuery subQuery:
                    alias.AddTable(subQuery.AliasName);
                    break;
                case BracketedSource bracketed:
                    alias.AddTable(bracketed.AliasName);
                    break;
                case JoinSource join:
                    {
                        AddTable(join.Left, alias);
                        AddTable(join.Right, alias);
                    }
                    break;
                default:
                    break;
            }
        }

        public override void VisitBefore(SingleQueryClause query)
        {
            if (query.Parent is AliasedQuery)
            {
                aliases.Push(new Alias());
            }
            else
            {
                aliases.TryPeek(out var alias);
                aliases.Push(new Alias(alias));
            }
        }
        public override void VisitAfter(SingleQueryClause query)
        {
            var alias = aliases.Pop();
            if (alias.Check())
            {
                throw new ColumnTableNameNotFoundException(query, alias.UnKnowAlias);
            }
        }
    }
}
