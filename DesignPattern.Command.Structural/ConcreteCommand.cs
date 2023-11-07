using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Structural
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
            
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
