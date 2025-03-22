using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Ratchet : IRatchet
    {
        private double driveSizeInInches = 0.5;

        public void ConnectToSocket()
        {
            Console.WriteLine("The 1/2 ratchet is ready to be used with a socket.");
        }
    }
}
