namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer firstCustomer = new Customer("Ivan", "Mladost", "Banishora");
            Customer secondCustomer = new Customer("Petar","Orlandovci","Boyana");

            TaxiCompany nBerCompany = new TaxiCompany("nBer");
            nBerCompany.TakeCall(firstCustomer);
            nBerCompany.TakeCall(secondCustomer);
            Taxi taxi = new Taxi("Kia", "K5", "Georgi");
            nBerCompany.SendTaxi(taxi);
        }
    }
}
