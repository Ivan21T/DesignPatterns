namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();
            Waiter waiter = new Waiter();
            ICommand cheeseburgerCommand = new CookCheeseburgerCommand(cook);
            ICommand saladCommand = new CookSaladCommand(cook);
            ICommand pizzaCommand=new CookPizzaCommand(cook);
            waiter.SetCommand(cheeseburgerCommand);
            waiter.PlaceOrder();

            waiter.SetCommand(saladCommand);
            waiter.PlaceOrder();

            waiter.SetCommand(pizzaCommand);
            waiter.PlaceOrder();
        }
    }
}
