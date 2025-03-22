using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CityBus:Vehicle
    {
        public CityBus(string brand, string model, ushort hp):base(brand,model,hp)
        { }
    }
}
