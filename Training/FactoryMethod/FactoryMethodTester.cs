using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.FactoryMethod
{
   static class FactoryMethodTester
    {
        public static void Test()
        {
            Delivery delivery = new BikeDelivery();
            delivery.Handle();

            delivery= new CarDelivery();
            delivery.Handle();

            Console.ReadKey();
        }
    }
}
