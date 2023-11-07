using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State.Structural
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    public class ConcreteStateA : State
    {
        public override void Handler(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
