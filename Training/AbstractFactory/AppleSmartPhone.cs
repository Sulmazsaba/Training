using System;

namespace Training.AbstractFactory
{
    class AppleSmartPhone : ISmartPhone
    {
        public void SwitchOn()
        {
            Console.WriteLine("Apple Smart Phone is switching on...");
        }

        public void Ring()
        {
            Console.WriteLine("Apple Smart Phone is ringing....");
        }
    }
}