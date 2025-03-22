using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class BankAccount : IAccount
    {
        public decimal Balance { get; set; }
        public BankAccount(decimal balance)
        {
            Balance = balance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount cannot be negative number or zero");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Not enough money in the balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Remaining money in the balance:{0}",Balance);
            }
        }
    }
}
