using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class VendingMachine{
        public decimal money;
        public int priceOfItem;
        public int availableItem;
        VendingMachineState vendingMachineState;
        public VendingMachine(int priceOfItem){
            vendingMachineState = new NoMoneyState();
            this.priceOfItem=priceOfItem;
            availableItem = 25;
            Money = 0;
        }

        public void InsertMoney(decimal money) {
            vendingMachineState.InsertMoney(this,money);
        }
        public void SelectItem() { 
            vendingMachineState.SelectItem(this);
        }
        public void GetItem() {
            vendingMachineState.GetItem(this);
        }
        public decimal Money{  get { return money; } set { money = value; } }
        public int PriceOfItem { get { return priceOfItem; } set { priceOfItem = value; } }
        public int AvailableItem {  get { return availableItem; } set { availableItem = value; } }
        public VendingMachineState VendingMachineState{ get { return vendingMachineState; } set { vendingMachineState = value; } }
    }
}
