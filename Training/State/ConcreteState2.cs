using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.State
{
   public  class ConcreteState2 : State
    {
        public override void DoThis()
        {
           Console.WriteLine("Do this from ConcreteState2");
        }

        public override void DoThat()
        {
           Console.WriteLine("Do That From ConcreteState2");
        }
    }
}
