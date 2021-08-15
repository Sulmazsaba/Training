using System;

namespace Training.AbstractFactory
{
    class SamsungTablet : ITablet
    {
        public void SwitchOn()
        {
            Console.WriteLine("Samsung tablet is switching on...");
        }
    }
}