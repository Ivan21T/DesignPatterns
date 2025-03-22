using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Check : IAccount
    {
        private decimal amount;
        private string authentificationPhrase;
        private BankAccount bankAccount;
        public Check(decimal amount, BankAccount bankAccount,string phrase)
        {
            this.amount = amount;
            this.bankAccount = bankAccount;
            this.authentificationPhrase = phrase;
        }
        public void Withdraw(decimal amount)
        {
            Console.Write("Enter the authentification phrase:");
            string phrase=Console.ReadLine();
            if (phrase == authentificationPhrase)
            {
                bankAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Cannot withdraw money from the balance");
            }
        }
    }
}
