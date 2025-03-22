using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Boeing737:Plane
    {
        public Boeing737(ControlTower controlTower,string name):base(controlTower,name)
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
