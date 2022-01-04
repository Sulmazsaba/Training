using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Interpreter
{
   public class YearExpression : IExpression
    {
        public void Evaluate(Context context)
        {

            context.Expression = context.Expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
