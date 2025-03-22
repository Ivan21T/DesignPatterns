using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CookSaladCommand : ICommand
    {
        private Cook cook;

        public CookSaladCommand(Cook cook)
        {
            this.cook = cook;
        }

        public void Execute()
        {
            cook.CookSalad();
        }
    }
}
