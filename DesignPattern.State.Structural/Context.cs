using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State.Structural
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        State state;

        public Context(State state)
        {
            this.state = state;
        }

        // Gets or sets the state
        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handler(this);
        }
    }
}
