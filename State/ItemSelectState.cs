using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ItemSelectState : VendingMachineState
    {
        public override void GetItem(VendingMachine vendingMachine){
            Console.WriteLine("You can get your item!");
            vendingMachine.VendingMachineState= new NoMoneyState();
        }

        public override void InsertMoney(VendingMachine vendingMachine, decimal money){
            Console.WriteLine("You have already put money!");
        }

        public override void SelectItem(VendingMachine vendingMachine){
            Console.WriteLine("You have already selected item!");
        }
    }
}
