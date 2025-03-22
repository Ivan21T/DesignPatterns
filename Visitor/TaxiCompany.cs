using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class TaxiCompany
    {
        private List<Customer> customerList=new List<Customer>();
        private string companyName;

        public TaxiCompany(string companyName)
        {
            this.companyName = companyName;
        }
        public void TakeCall(Customer customer)
        {
            customerList.Add(customer);
        }
        public void SendTaxi(Taxi taxi)
        {
            foreach (Customer customer in customerList)
            {
                customer.Accept(taxi);
            }
            customerList.Clear();
        }
    }
}
