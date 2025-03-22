using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Mediator
{
    public class ControlTower
    {
        private List<Plane> planes=new List<Plane>();
        private bool isLandingInProgress = false;
        private bool isTakeoffInProgress = false;
        public ControlTower()
        {
        }
        public ControlTower(List<Plane> planes)
        {
            this.planes = planes;
        }
        public void GivingPermissionForLand(Plane plane)
        {
            if (isLandingInProgress)
            {
                Console.WriteLine($"{plane.Name} cannot land right now. Another plane is landing.");
                return;
            }
            if (plane.IsLanded)
            {
                Console.WriteLine($"{plane.Name} is already landed.");
                return;
            }
            Console.WriteLine($"{plane.Name} is landing.");
            isLandingInProgress = true;
            Thread.Sleep(3000);
            plane.IsLanded = true;
            Console.WriteLine($"{plane.Name} has landed.");
            isLandingInProgress = false;
        }

        public void GivingPermissionForTakingoff(Plane plane)
        {
            if (isTakeoffInProgress)
            {
                Console.WriteLine($"{plane.Name} cannot take off right now. Another plane is taking off.");
                return;
            }
            if (!plane.IsLanded)
            {
                Console.WriteLine($"{plane.Name} is already in the air.");
                return;
            }
            Console.WriteLine($"{plane.Name} is taking off.");
            isTakeoffInProgress = true;
            Thread.Sleep(3000);
            plane.IsLanded = false;
            Console.WriteLine($"{plane.Name} has taken off.");
            isTakeoffInProgress = false;
        }
    }
}
