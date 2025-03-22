using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Fan :IDevice
    {
        public void On()
        {
            Console.WriteLine("The device is on");
        }
        public void Off()
        {
            Console.WriteLine("The device is off");
        }
    }
}
