using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.Structural
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandlerRequest(int request);
    }
}
