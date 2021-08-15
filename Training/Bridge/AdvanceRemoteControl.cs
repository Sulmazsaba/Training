using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Bridge
{
    public class AdvanceRemoteControl : RemoteControl
    {
       
        public AdvanceRemoteControl(IDevice device) : base(device)
        {
           
        }


        public void SetChannel()
        {
            _device.SetChannel(4);
        }

    }
}
