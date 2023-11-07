using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.Structural
{
    /// <summary>
    /// The 'ConcreteHandler2' class
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
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
