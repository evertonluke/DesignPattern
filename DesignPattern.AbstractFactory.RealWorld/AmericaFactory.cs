using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.RealWorld
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
