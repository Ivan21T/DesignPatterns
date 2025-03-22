using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Switch
    {
        protected IDevice device;
        public Switch(IDevice device)
        {
            this.device = device;
        }
        public abstract void Toggle();
    }
}
