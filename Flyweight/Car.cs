using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Car
    {
        public int HorsePower { get; set; }
        public string Color {  get; set; }
        public string Number {  get; set; }
        public Car(int horsePower,string color,string number) 
        {
            HorsePower = horsePower;
            Color = color;
            Number = number;
        }
        public void Drive()
        {
            Console.WriteLine("I drive {0} car with {1} hp, number: {2}",Color,HorsePower,Number);
        }
    }
}
