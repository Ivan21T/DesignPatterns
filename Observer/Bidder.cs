using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Bidder
    {
        decimal budget;
        string name;
        Random random = new Random();
        public Bidder(string name,decimal budget)
        { 
            this.name = name;
            this.budget = budget;
        }
        public void MakeOffer()
        {
            int price=random.Next(0,(int)budget);
            Console.WriteLine("I will give you {0}",price); 
        }
    }
}
