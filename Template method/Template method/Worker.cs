using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method
{
    public abstract class Worker
    {
        protected string name;
        protected decimal salary;

        protected Worker(string name,decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public abstract void GetUp();
        public abstract void EatBreakfast();
        public abstract void GoToWork();
        public abstract void Work();
        public abstract void ReturnToHome();
        public abstract void Relax();
        public abstract void Sleep();
    }
}
