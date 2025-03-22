using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Vehicle
    {
        protected string brand;
        protected string model;
        protected ushort hp;
        public Vehicle(string brand, string model, ushort hp)
        {
            this.brand = brand;
            this.model = model;
            this.hp = hp;
        }
    }
}
