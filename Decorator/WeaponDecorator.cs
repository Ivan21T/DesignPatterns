using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class WeaponDecorator : IWeapon
    {
        private Weapon weapon;
        public WeaponDecorator(Weapon weapon)
        {
            this.weapon = weapon;
        }
        public virtual void AimAndFire()
        {
            weapon.AimAndFire();
        }
    }
}
