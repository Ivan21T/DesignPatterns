using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class TwentyDollarHandler : HandlerOfResponsibility
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 20)
            {
                int bills = amount / 20;
                Console.WriteLine($"Return {bills} x $20");
                amount -= bills * 20;
            }

            if (amount > 0 && nextHandler != null)
            {
                nextHandler.HandleRequest(amount);
            }
        }
    }
}
