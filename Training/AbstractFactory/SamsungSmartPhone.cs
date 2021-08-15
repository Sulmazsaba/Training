using System;

namespace Training.AbstractFactory
{
    class SamsungSmartPhone : ISmartPhone
    {
        public void SwitchOn()
        {
            Console.WriteLine("Samsung Smart Phone is switching on...");
        }

        public void Ring()
        {
            Console.WriteLine("Samsung Smart Phone is ringing...");
        }
    }
}