using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CookCheeseburgerCommand : ICommand
    {
        private Cook cook;

        public CookCheeseburgerCommand(Cook cook)
        {
            this.cook = cook;
        }

        public void Execute()
        {
            cook.CookCheeseburger();
        }
    }
}
