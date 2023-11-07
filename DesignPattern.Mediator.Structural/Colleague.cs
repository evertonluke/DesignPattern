using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.Structural
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
