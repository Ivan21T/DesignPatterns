using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class FiftyDollarHandler:HandlerOfResponsibility
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 50)
            {
                int bills = amount / 50;
                Console.WriteLine($"Return {bills} x $50");
                amount -= bills * 50;
            }

            if (amount > 0 && nextHandler != null)
            {
                nextHandler.HandleRequest(amount);
            }
        }
    }
}
