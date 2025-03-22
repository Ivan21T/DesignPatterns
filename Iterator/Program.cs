using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"BNT","BTV","NOVA","Diema","MaxSport"};
            TunedChannel tunedChannel = new TunedChannel(list);
            tunedChannel.Traversal();
        }
    }
}
