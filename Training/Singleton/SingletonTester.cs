using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Singleton
{
  public  static  class SingletonTester
    {
        public static void Test()
        {
           var instance = Singleton.GetInstance();

           instance.Name = "Saba";

           var instance2 = Singleton.GetInstance();


           Console.WriteLine(instance2.Name);

           Console.ReadKey();
        }
    }
}
