using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class HundredDollarHandler : HandlerOfResponsibility
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 100)
            {
                int bills = amount / 100;
                Console.WriteLine($"Return {bills} x $100");
                amount -= bills * 100;
            }

            if (amount > 0 && nextHandler != null)
            {
                nextHandler.HandleRequest(amount);
            }
        }
    }
}
