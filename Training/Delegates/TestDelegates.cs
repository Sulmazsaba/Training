using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Delegates
{
  public static class TestDelegates
    {
        
        public delegate void MyDelegate(string msg); //declaring a delegate

        public delegate int IntTypeDelegate();

        public delegate T Add<T>(T param1, T param2); // generic delegate

        public static void Test()
        {
            
            MyDelegate del = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            del("Hello World");
            del.Invoke("Hello World");

            del = ClassB.MethodB ;
            del.Invoke("Hello World");

            DelegateFunctions.InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");


            MyDelegate del3 = del + del2;
            del3("hello");

            Console.ReadLine();
        }
    }
}
