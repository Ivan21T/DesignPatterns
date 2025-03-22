using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Taxi : Vehicle
    {
        public Taxi(string brand,string model,ushort hp):base(brand,model,hp)
        {
        }
    }
}
