using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.Structural
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }
}
