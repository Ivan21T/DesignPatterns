
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice fan = new Fan();
            Switch switchForFan = new SwitchForDevice(fan);
            switchForFan.Toggle();
        }
    }
}
