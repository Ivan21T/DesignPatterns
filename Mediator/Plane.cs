using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Plane
    {
        protected ControlTower controlTower;
        public string name;
        public bool IsLanded { get; set; }
        public Plane(ControlTower controlTower, string name)
        {
            this.controlTower = controlTower;
            this.name = name;
            IsLanded = false;
        }
        public string Name
        {
        get { return name; } }
        public abstract void RequestForLanding();
        public abstract void RequestForTakingOff();
    }
}
