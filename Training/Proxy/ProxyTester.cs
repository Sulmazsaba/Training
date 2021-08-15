using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Proxy
{
   public static class ProxyTester
    {

        public static void Test()
        {
            var library = new Library();
            string[] files = new string[]{"a", "b", "c"};

            foreach (var file in files)
            {
                library.AddEBook(new EBookProxy(file));
            }

            library.OpenEBook("a");

            Console.ReadKey();
        }
    }
}
