using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Bridge
{
   public static class BridgeTester
    {
        public static void Test()
        {
            IDevice device= new SonyDevice();

            AdvanceRemoteControl remoteControl = new AdvanceRemoteControl(device);

            remoteControl.SetChannel();

            Console.ReadKey();
        }
    }
}
