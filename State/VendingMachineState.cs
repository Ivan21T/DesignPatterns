using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class VendingMachineState{
        public abstract void InsertMoney(VendingMachine vendingMachine,decimal money);
        public abstract void SelectItem(VendingMachine vendingMachine);
        public abstract void GetItem(VendingMachine vendingMachine);
    }
}
