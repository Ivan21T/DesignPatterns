using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public abstract class HandlerOfResponsibility
    {
        protected HandlerOfResponsibility nextHandler;

        public void SetNextHandler(HandlerOfResponsibility nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void HandleRequest(int amount);
    }
}
