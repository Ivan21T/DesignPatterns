using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class AdapterRatchetToSocket : ISocket
    {
        private  Ratchet ratchet;

        public AdapterRatchetToSocket(Ratchet ratchet)
        {
            this.ratchet = ratchet;
        }

        public void ConnectToRatchet()
        {
            ratchet.ConnectToSocket();
            Console.WriteLine("Successful connection between ratchet 1/2 drive and socket 1/4 drive");
        }
    }
}
