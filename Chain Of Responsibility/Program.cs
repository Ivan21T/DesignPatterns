namespace Chain_Of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hundredHandler = new HundredDollarHandler();
            var fiftyHandler = new FiftyDollarHandler();
            var twentyHandler = new TwentyDollarHandler();
            var tenHandler = new TenDollarHandler();

            hundredHandler.SetNextHandler(fiftyHandler);
            fiftyHandler.SetNextHandler(twentyHandler);
            twentyHandler.SetNextHandler(tenHandler);

            int money = 280;
            Console.WriteLine($"Requesting withdrawal of ${money}");
            hundredHandler.HandleRequest(money);
        }
    }
}
