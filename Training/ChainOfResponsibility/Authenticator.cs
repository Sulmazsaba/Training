using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.ChainOfResponsibility
{
   public class Authenticator : Handler
    {
        public Authenticator(Handler handler) : base(handler)
        {
        }

        public override bool DoHandle()
        {
            Console.WriteLine("Authenticate");
            return true;
        }
    }
}
