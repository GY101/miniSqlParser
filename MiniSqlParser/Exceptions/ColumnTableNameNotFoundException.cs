using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSqlParser.Exceptions
{
    public class ColumnTableNameNotFoundException : Exception
    {
        public string FromSql { get; }
        public IEnumerable<string> TableName { get; }
        public ColumnTableNameNotFoundException(INode node, IEnumerable<string> tableName)
        {
            var beautiful = new BeautifulStringifier(2048);
            node.Accept(beautiful);
            FromSql = beautiful.ToString();
            TableName = tableName;
        }
        public override string Message => $"Query {FromSql} , Unknown Table Name ({(string.Join(",", TableName))}) "; 
    }
}
