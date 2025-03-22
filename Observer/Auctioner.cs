using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public delegate void BidRejection();
    public class Auctioner
    {
        public event BidRejection OnBidRejected;
        string item;
        Random random = new Random();
        public Auctioner(string item)
        {
            this.item = item;
        }
        public void AcceptBid()
        {
            bool auctionOngoing = true;

            while (auctionOngoing)
            {
                bool take = random.Next(0, 2) == 1;

                if (take)
                {
                    Console.WriteLine("I will take better offer! The auction ends!");
                    auctionOngoing = false;
                }
                else
                {
                    Console.WriteLine("Give me a new offer!");
                    OnBidRejected?.Invoke();
                }
            }
        }
    }
}
