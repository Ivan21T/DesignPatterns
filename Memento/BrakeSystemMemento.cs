using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class BrakeSystemMemento
    {
        public string LeftBrake {  get; private set; }
        public string RightBrake { get; private set; } 

        public BrakeSystemMemento(string leftBrake,string rightBrake)
        {
            LeftBrake = leftBrake;
            RightBrake = rightBrake;
        }
    }
}
