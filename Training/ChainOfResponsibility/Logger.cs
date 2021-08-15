using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.ChainOfResponsibility
{
   public class Logger : Handler
    {
        public Logger(Handler handler) : base(handler)
        {
        }

        public override bool DoHandle()
        {
            Console.WriteLine("login");
            return true;
        }
    }
}
