using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ChannelIterator : IIterator
    {
        private List<string> channels = new List<string>();
        private int channelsCount;
        private int currentChannel=0;

        public ChannelIterator(List<string> channels, int channelsCount, int currentChannel)
        {
            this.channels = channels;
            this.channelsCount = channelsCount;
            this.currentChannel = currentChannel;
        }

        public void Next()
        {
            if (currentChannel == channelsCount-1)
            {
                currentChannel = 0;
                Console.WriteLine("You are now in {0}", channels[currentChannel]);
            }
            else
            {
                currentChannel++;
                Console.WriteLine("You are now in {0}", channels[currentChannel]);
            }
        }
        public void Previous()
        {
            if (currentChannel == 0)
            {
                currentChannel = channelsCount-1;
                Console.WriteLine("You are now in {0}", channels[currentChannel]);
            }
            else
            {
                currentChannel--;
                Console.WriteLine("You are now in {0}", channels[currentChannel]);
            }
        }
    }
}
