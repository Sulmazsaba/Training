using System;

namespace Training.FactoryMethod
{
    public  class Car : IVehicle
    {
        public string Name { get; set; }
        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }
    }
}