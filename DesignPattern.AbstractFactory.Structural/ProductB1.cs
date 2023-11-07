using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Structural
{
    /// <summary>
    /// The 'ProductB1' classe
    /// </summary>
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
