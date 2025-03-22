using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class MoneyState : VendingMachineState
    {
        public override void GetItem(VendingMachine vendingMachine){
            
        }

        public override void InsertMoney(VendingMachine vendingMachine,decimal money){
            Console.WriteLine("You have already put money!");
        }

        public override void SelectItem(VendingMachine vendingMachine)
        {
            Console.WriteLine("You selcect item!");
            if (vendingMachine.AvailableItem != 0){
                vendingMachine.VendingMachineState = new ItemSelectState();
                vendingMachine.AvailableItem--;
            }
            else{
                Console.WriteLine("Not enough quantity!");
            }
        }
    }
}
