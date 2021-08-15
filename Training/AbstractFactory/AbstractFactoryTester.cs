using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.AbstractFactory
{
   public static  class AbstractFactoryTester
    {

        public static void Test()
        {
            ProductTester productTester=new ProductTester();
            productTester.Test(new AppleFactory());
            productTester.Test(new SamsungFactory());

            Console.ReadKey();
        }
    }
}
