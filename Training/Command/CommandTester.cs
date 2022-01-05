using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Command.Undoable;

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

        public static void TestUndoableCommand()
        {
            var history = new History();
            var document = new HtmlDocument();

            document.Content = "sa sa sa";
            var command = new BoldCommand(document, history);

            command.Execute();
            Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);
            Console.ReadKey();
        }
    }
}
