using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Template
{
   public static class TemplateTester
    {
        public static void Test()
        {
            var task = new MoneyTransferTask();
            task.Execute("transferring money has done");

           var task2 = new GenerateReportTask();
            task2.Execute("generating report has done");

            Console.ReadKey();
        }
    }
}
