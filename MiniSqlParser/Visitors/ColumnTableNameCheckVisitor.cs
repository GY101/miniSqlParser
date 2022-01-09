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
        }
        Stack<Alias> aliases = new Stack<Alias>();
        public override void Visit(Column column)
        {
            var alias = aliases.Peek();
            if (column.TableAliasName != null)
            {
                alias.AddColumn(column.TableAliasName.Id);
            }
        }
        public override void Visit(Table table)
        {
            var alias = aliases.Peek();
            alias.AddTable(table.Name);
            if (table.HasAs)
            {
                alias.AddTable(table.AliasName);
            }
        }
        public override void VisitOnFrom(SingleQueryClause query, int offset)
        {
            var alias = aliases.Peek();
            switch (query.From)
            {
                case AliasedQuery subQuery:
                    alias.AddTable(subQuery.AliasName);
                    break;
                case BracketedSource bracketed:
                    alias.AddTable(bracketed.AliasName);
                    break;
                default:
                    break;
            }
        }

        public override void VisitBefore(SingleQueryClause query)
        {
            aliases.TryPeek(out var alias);
            aliases.Push(new Alias(alias));

        }
        public override void VisitAfter(SingleQueryClause query)
        {
            var alias = aliases.Pop();
            if (alias.Check())
            {
                throw new Exception("error");
            }
        }
    }
}
