using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento.Structural
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string State
        {
            get { return this.state; }
        }
    }
}
