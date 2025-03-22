using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Service
    {
        private readonly OrderSystem _orderSystem;
        private readonly BillingSystem _billingSystem;
        private readonly DeliverySystem _deliverySystem;

        public Service()
        {
            _orderSystem = new OrderSystem();
            _billingSystem = new BillingSystem();
            _deliverySystem = new DeliverySystem();
        }

        public void PlaceOrder(string product, int quantity,decimal productPrice)
        {
            _orderSystem.GetOrder(product, quantity);
            _billingSystem.GetBill(productPrice, quantity);
            _deliverySystem.Delivery(product, quantity);
            Console.WriteLine("Order completed");
        }
    }
}
