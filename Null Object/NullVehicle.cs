using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object
{
    public class NullVehicle : Vehicle
    {
        public NullVehicle():base("Unknown","UnKnown")
        {
            this.type = "Unknown";
        }
        public override void DisplayInfo()
        {
        }
    }
}
