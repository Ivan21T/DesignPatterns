using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Waiter
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Order received!");
            command.Execute();
        }
    }
}
