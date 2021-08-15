using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Builder
{
    public interface IQueryBuilder
    {

        IQueryBuilder Table(string tableName);

        IQueryBuilder Select(string[] cols);

        IQueryBuilder Where(string col,string value);

        IQueryBuilder Limit();
        string GetQuery();
    }
}
