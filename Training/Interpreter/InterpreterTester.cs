using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Interpreter
{
    class InterpreterTester
    {
        public static void Test()
        {
            var expressions = new List<IExpression>();

            Context context = new Context(DateTime.Now);
            context.Expression = "DD MM YYYY";

            var strArray = context.Expression.Split(' ');
            foreach (var item in strArray)
            {
                if(item == "DD")
                    expressions.Add(new DayExpression());
                else if(item == "MM")
                    expressions.Add(new MonthExpression());
                else if(item == "YYYY")
                    expressions.Add(new YearExpression());
            }

            expressions.Add(new SeparatorExpression());

            foreach (var obj in expressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.Expression.ToString());
            Console.ReadKey();
        }

    }
}
