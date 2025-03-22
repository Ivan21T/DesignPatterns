using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Mechanic
    {
        private List<BrakeSystemMemento> mementoList = new List<BrakeSystemMemento>();

        public void AddMemento(BrakeSystemMemento memento)
        {
            mementoList.Add(memento);
        }

        public BrakeSystemMemento GetMemento(int index)
        {
            return mementoList[index];
        }
    }
}
