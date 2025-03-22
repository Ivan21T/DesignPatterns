using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Customer
    {
        private string name;
        private string location;
        private string destination;
        public Customer(string name,string location, string destination)
        {
            this.name = name;
            this.location = location;
            this.destination = destination;
        }
        public string Name
            { get { return name; } }
        public string Location
            { get { return location; } }
        public string Destination
            { get { return destination; } }
        public void Accept(Taxi taxi)
        {
            taxi.Visit(this);
        }
    }
}
