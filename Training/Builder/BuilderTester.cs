using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Builder
{
 public  static class BuilderTester
    {

        public static void Test()
        {
            IQueryBuilder builder = new SqlServerQueryBuilder();
            string[] cols = new[] {"Name", "Family"};
           var query= builder.Select(cols).Table("Orders").Where("Name","Sulmaz").GetQuery();

           Console.WriteLine(query);
           Console.ReadKey();

        }
    }
}
