using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.Structural
{
    /// <summary>
    /// The 'ConcreteHandler3' class
    /// </summary>
    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request <= 30)
            {
                Console.WriteLine("{0} handler request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}
