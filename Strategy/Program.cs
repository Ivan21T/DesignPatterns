using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        public static string SelectTransportionToAirport()
        {
            string decision = null;
            Console.Write("Do you own a car?");
            string answer=Console.ReadLine();
            Console.Write("What is your budget for transport?");
            decimal budget = int.Parse(Console.ReadLine());
            Console.Write("How long do you want to travel?");
            int timeInMinutes=int.Parse(Console.ReadLine());
            if (answer.ToLower()=="yes" && budget>=8)
            {
                decision = "car";
            }
            else if (answer.ToLower()=="no" && budget>=1 && timeInMinutes>=15)
            {
                decision = "city bus";
            }
            else if(answer.ToLower()=="no" && budget>=15 && timeInMinutes>=10)
            {
                decision = "taxi";
            }
            else
            {
                decision = "on foot";
            }
            return decision;
        }
        static void Main(string[] args)
        {
            object vehicle=null;
            string decision=SelectTransportionToAirport();
            vehicle=StrategyClass.ReturnVehicleByDecision(decision);
        }
    }
}
