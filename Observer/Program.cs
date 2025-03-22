using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auctioner auctioner = new Auctioner("Vase");
            Console.Write("Give budget for bidder: ");
            Bidder firstBidder = new Bidder("Ivan", decimal.Parse(Console.ReadLine()));
            Console.Write("Give budget for bidder: ");
            Bidder secondBidder = new Bidder("Petar", decimal.Parse(Console.ReadLine()));

            auctioner.OnBidRejected += firstBidder.MakeOffer;
            auctioner.OnBidRejected += secondBidder.MakeOffer;

            firstBidder.MakeOffer();
            secondBidder.MakeOffer();
            auctioner.AcceptBid();
        }
    }
}
