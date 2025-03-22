using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object
{
    public class Car:Vehicle
    {
        private int doorNumber;

        public Car(string brand, string model, int doorNumber) : base(brand, model)
        {
            this.type = "car";
            this.doorNumber = doorNumber;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Type: {0}, Brand: {1}, Model: {2}, Door number:{3}",this.type,this.brand,this.model,this.doorNumber);
        }
    }
}
