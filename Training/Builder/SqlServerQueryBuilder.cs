using System.Text;

namespace Training.Builder
{
   public class SqlServerQueryBuilder : IQueryBuilder
    {
        private StringBuilder _query;
        private string _tableName;

        public SqlServerQueryBuilder()
        {
            _query = new StringBuilder();
        }

        public IQueryBuilder Table(string tableName)
        {
            _tableName = tableName;
            return this;
        }

        public IQueryBuilder Select(params string[] cols)
        {
            _query.Append("SELECT");
            foreach (var col in cols)
            {
                _query.Append($" {col}, ");
            }
            return this;
        }

        public IQueryBuilder Where(string col, string value)
        {
            return this;
        }

        public IQueryBuilder Limit()
        {
            return this;
        }

        public string GetQuery()
        {
            return _query.ToString();
        }
    }
}