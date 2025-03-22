using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object
{
    public class Motorcycle:Vehicle
    {
        private bool hasSidecar;

        public Motorcycle(string brand,string model,bool hasSidecar):base(brand,model)
        {
            this.type = "motorcycle";
            this.hasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Type: {0}, Brand: {1}, Model: {2}, Has sidecar: {3}",this.type,this.brand,this.model,this.hasSidecar);
        }
    }
}
