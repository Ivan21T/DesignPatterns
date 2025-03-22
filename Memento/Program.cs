namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrakeSystem brakeSystem = new BrakeSystem();
            Mechanic mechanic = new Mechanic();
            brakeSystem.SetState("Cleaned", "Cleaned");
            brakeSystem.PrintState();
            mechanic.AddMemento(brakeSystem.SaveStateToMemento());
            brakeSystem.SetState("Cleaned", "Disassembled");
            brakeSystem.PrintState();
            brakeSystem.RestoreStateFromMemento(mechanic.GetMemento(0));
            brakeSystem.PrintState();
        }
    }
}
