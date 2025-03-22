using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Taxi
    {
        private string brand;
        private string model;
        private string driverName;

        public Taxi(string brand,string model,string driverName)
        {
            this.brand = brand;
            this.model = model;
            this.driverName = driverName;
        }
        public void Visit(Customer customer)
        {
            Console.WriteLine("Take customer {0} from {1} and drive him to {2}",customer.Name,customer.Location,customer.Destination);
        }
    }
}
