using System;

namespace Training.AbstractFactory
{
    class AppleTablet : ITablet
    {
        public void SwitchOn()
        {
            Console.WriteLine("Apple Tablet is switching on...");
        }
    }
}