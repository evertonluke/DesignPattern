using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.RealWorld
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class NonBeatle : Participant
    {
        public NonBeatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
