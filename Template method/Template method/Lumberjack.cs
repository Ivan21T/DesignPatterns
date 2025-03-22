using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method
{
    public class Lumberjack : Worker
    {
        public Lumberjack(string name, decimal salary) : base(name, salary)
        {

        }
        public override void ReturnToHome()
        {
            Console.WriteLine("I go home after 24 hours work.");
        }
        public override void EatBreakfast()
        {
            Console.WriteLine("I eat at 7 am");
        }
        public override void GetUp()
        {
            Console.WriteLine("I get up at 6:30 am");
        }
        public override void GoToWork()
        {
            Console.WriteLine("I go to work at 8 am ");
        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep from 10 pm to 6:30 am");
        }
        public override void Work()
        {
            Console.WriteLine("I work as a lumberjack");
        }
        public override void Relax()
        {
            Console.WriteLine("I relax after 5:30 pm");
        }
    }
}

