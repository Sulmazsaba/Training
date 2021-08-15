using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Memento
{
   public static class MementoTester
    {
        public static void Test()
        {
            var originator= new  Originator();
            var careTaker = new CareTaker();


            originator.Content = "Item 1";
           careTaker.Push(originator.CreateMemento());

           originator.Content = "Item 2";
           careTaker.Push(originator.CreateMemento());


           originator.Content = "Item 3";
          originator.RestoreMemento(careTaker.Pop());

          Console.WriteLine(originator.Content);
          Console.ReadKey();

        }
    }
}
