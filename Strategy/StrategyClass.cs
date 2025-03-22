using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class StrategyClass
    {
        public static object ReturnVehicleByDecision(string decision)
        {
            object vehicle = null;
            if (decision == "car")
            {
                Console.WriteLine("You have to go with your own car!");
                Console.Write("Give the model,brand and hp of car: ");
                List<string> arguments = Console.ReadLine().Split().ToList();
                string brand = arguments[0];
                string model = arguments[1];
                ushort hp = ushort.Parse(arguments[2]);
                vehicle = new Car(brand, model, hp);
            }
            else if (decision == "city bus")
            {
                Console.WriteLine("You have to go by city bus!");
                Console.Write("Give the model,brand and hp of the bus: ");
                List<string> arguments = Console.ReadLine().Split().ToList();
                string brand = arguments[0];
                string model = arguments[1];
                ushort hp = ushort.Parse(arguments[2]);
                vehicle = new CityBus(brand, model, hp);
            }
            else if (decision == "taxi")
            {
                Console.WriteLine("You have to go by taxi!");
                Console.Write("Give the model,brand and hp of the taxi: ");
                List<string> arguments = Console.ReadLine().Split().ToList();
                string brand = arguments[0];
                string model = arguments[1];
                ushort hp = ushort.Parse(arguments[2]);
                vehicle = new Taxi(brand, model, hp);
            }
            else if (decision == "on foot" || decision == null)
            {
                Console.WriteLine("You have to go on foot!");
            }
            return vehicle;
        }
    }
}
