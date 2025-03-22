using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ScopedWeapon:WeaponDecorator
    {
        public ScopedWeapon(Weapon weapon):base(weapon) 
        { }

        public override void AimAndFire()
        {
            Console.WriteLine("My weapon have scope for better accuracy");
            base.AimAndFire();
        }
    }
}
