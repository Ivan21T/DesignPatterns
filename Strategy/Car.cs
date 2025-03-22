using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Car:Vehicle
    {
        public Car(string brand,string model,ushort hp):base(brand,model,hp) 
        { }
    }
}
