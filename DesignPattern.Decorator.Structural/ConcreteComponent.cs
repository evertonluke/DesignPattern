using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Structural
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
