using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoMoneyState : VendingMachineState
    {
        public override void InsertMoney(VendingMachine vendingMachine,decimal money) {
            if (money>=vendingMachine.PriceOfItem){
                vendingMachine.Money += vendingMachine.PriceOfItem;
                Console.WriteLine("Your remainder is: {0}",money-vendingMachine.PriceOfItem);
                vendingMachine.VendingMachineState = new MoneyState();
            }
            else{
                Console.WriteLine("Not enough money!");
            }
        }
        public override void SelectItem(VendingMachine vendingMachine) {
            Console.WriteLine("You have to put money in the machine!");
        }
        public override void GetItem(VendingMachine vendingMachine) {
            Console.WriteLine("You have to put money in the machine!");
        }
    }
}
