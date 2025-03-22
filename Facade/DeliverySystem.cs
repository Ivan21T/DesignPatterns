using System;

namespace Facade
{
    internal class DeliverySystem
    {
        public void Delivery(string product, int quantity)
        {
            Console.WriteLine("The order is on way, product:{0} with quantity:{1}",product,quantity);
        }
    }
}