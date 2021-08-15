using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Template
{
   public class MoneyTransferTask : Task
    {

        protected override void DoExecute()
        {
            Console.WriteLine("executing transferring money");
        }
    }
}
