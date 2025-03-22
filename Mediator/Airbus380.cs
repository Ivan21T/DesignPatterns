using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Airbus380:Plane
    {
        public Airbus380(ControlTower controlTower,string name):base(controlTower,name) 
        { }
        public override void RequestForLanding()
        {
            controlTower.GivingPermissionForLand(this);
        }
        public override void RequestForTakingOff()
        {
            controlTower.GivingPermissionForTakingoff(this);
        }
    }
}
