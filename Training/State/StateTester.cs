using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.State
{
   public static class StateTester
    {
        public static void Test()
        {
            var context = new Context(new ConcreteState1());
            context.DoThis();
            context.DoThat();

            Console.ReadKey();

        }
        
    }
}
