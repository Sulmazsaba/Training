using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Mediator
{
  public static class MediatorTester
    {
        public static void Test()
        {
            var dialogBox = new ArticlesDialogBox();

            dialogBox.SimulateUserInteraction();


            Console.ReadKey();
        }
    }
}
