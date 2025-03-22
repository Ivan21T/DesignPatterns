using System;

namespace Facade
{
    internal class BillingSystem
    {
        public void GetBill(decimal productPrice, int quantity)
        {
            Console.WriteLine("The bill is {0}",productPrice*quantity);
        }
    }
}