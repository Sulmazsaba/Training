using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Command
{
   public static class CommandTester
    {
        public static void Test()
        {
            var command = new AddCustomerCommand(new CustomerService());

            var button = new Button(command);

            button.Click();

            Console.ReadKey();
        }

        public static void TestCompositeCommand()
        {
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());

            composite.Execute();

            Console.ReadKey();
        }
    }
}
