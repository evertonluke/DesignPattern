using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Structural
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
