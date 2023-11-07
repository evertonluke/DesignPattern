using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.Structural
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            // and then call SpecificRequest

            adaptee.SpecificRequest();
        }
    }
}
