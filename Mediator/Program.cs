using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlTower controlTower = new ControlTower();
            Plane firstBoeing = new Boeing737(controlTower, "Boeing 737 ->01");
            Plane firstAirbus = new Airbus380(controlTower, "Airbus 380 ->01");
            Plane secondAirbus = new Airbus380(controlTower, "Airbus 380 -> 02");
            firstBoeing.RequestForLanding();
            firstAirbus.RequestForTakingOff();
            secondAirbus.RequestForLanding();
            firstBoeing.RequestForTakingOff();
        }
    }
}
