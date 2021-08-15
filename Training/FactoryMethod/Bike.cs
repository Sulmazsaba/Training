using System;

namespace Training.FactoryMethod
{
    public class Bike : IVehicle
    {
        public string Name { get; set; }
        public void Move()
        {
            Console.Write("Bike is Moving");
        }
    }
}