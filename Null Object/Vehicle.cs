using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object
{
    public abstract class Vehicle
    {
        protected string type;
        protected string brand;
        protected string model;

        public Vehicle(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public abstract void DisplayInfo();
    }
}
