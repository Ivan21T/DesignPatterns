using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Weapon : IWeapon
    {
        private string type;
        private int quantityOfBullets;
        
        public Weapon(string type,int bullets)
        {
            this.type = type;
            this.quantityOfBullets = bullets;
        }

        public void AimAndFire()
        {
            Console.WriteLine("Firing the weapon");
        }
    }
}
