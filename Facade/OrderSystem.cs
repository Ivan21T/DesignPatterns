using System;

namespace Facade
{
    internal class OrderSystem
    {
        public void GetOrder(string product, int quantity)
        {
            Console.WriteLine("Order placed: {0} with quantity {1}", product,quantity);
        }
    }
}