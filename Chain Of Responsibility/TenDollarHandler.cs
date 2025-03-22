using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class TenDollarHandler:HandlerOfResponsibility
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 10)
            {
                int bills = amount / 10;
                Console.WriteLine($"Return {bills} x $10");
                amount -= bills * 10;
            }

            if (amount > 0 && nextHandler != null)
            {
                nextHandler.HandleRequest(amount);
            }
        }
    }
}
