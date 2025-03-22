using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class TunedChannel
    {
        List<string> channels=new List<string>();
        ChannelIterator iterator;
        public TunedChannel(List<string> channels)
        {
            this.channels = channels;
            iterator = new ChannelIterator(channels, channels.Count,1);
        }

        public void Traversal()
        {
            bool watchingChannel = false;
            Console.Write("Do you want to watch TV?/(yes or no): ");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                watchingChannel = true;
                while (watchingChannel)
                {
                    Console.Write("Next,previous or no: ");
                    string preference = Console.ReadLine();
                    if (preference == "next")
                    {
                        iterator.Next();
                    }
                    else if (preference == "previous")
                    {
                        iterator.Previous();
                    }
                    else {
                        break;
                    }
                }
            }
        }

    }
}
