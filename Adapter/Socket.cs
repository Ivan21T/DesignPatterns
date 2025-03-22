using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Socket : ISocket
    {
        private double sizeOfSocketInInches = 0.25;
        public void ConnectToRatchet()
        {
            Console.WriteLine("The 1/4 female socket is ready to be connected");
        }
    }
}
