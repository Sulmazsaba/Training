using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Iterator
{
   static class IteratorTester
    {
        public static void Test()
        {
            var browserHistory = new BrowseHistory();
            browserHistory.Push("b");
            browserHistory.Push("f");
            browserHistory.Push("s");
            browserHistory.Push("w");

            IIterator iterator = browserHistory.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
