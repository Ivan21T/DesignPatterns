using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SwitchForDevice:Switch
    {
        public SwitchForDevice(IDevice device):base(device) 
        {
        }
        public override void Toggle()
        {
            device.On();
            Thread.Sleep(2000);
            device.Off();
        }
    }
}
