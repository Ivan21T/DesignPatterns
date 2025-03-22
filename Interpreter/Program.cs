using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Number 1: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Number 2: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Action: ");
                string answer = Console.ReadLine();
                if (answer.ToLower()=="add" || answer.ToLower()=="събиране")
                {
                    InterpreterClass.Аdd(a, b);
                }
                else if (answer.ToLower()=="division" || answer.ToLower()=="делене")
                {
                    InterpreterClass.Division(a, b);
                }
                else if (answer.ToLower() == "изваждане" || answer.ToLower() == "subtraction")
                {
                    InterpreterClass.Subtraction(a, b);
                }
                else if (answer.ToLower() == "умножение" || answer.ToLower() == "multiplication")
                {
                    InterpreterClass.Multiplication(a, b);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
