using System;

namespace Training.Bridge
{
    public class SonyDevice : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony Turn On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony Turn off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("Sony Set Channel");
        }
    }
}