using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class CarFactory
    {
        private static Dictionary<string, Car> cars = new Dictionary<string, Car>();
        public static Car GetCar(string number,int hp,string color)
        {
            if (!cars.ContainsKey(number))
            {
                Car car=new Car(hp,color,number);
                cars.Add(number,car);
                Console.WriteLine("Successful created new car");
                return car;
            }
            Console.WriteLine("Find searched car in the collection");
            return cars[number];
        }

    }
}
