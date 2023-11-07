using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.RealWorld
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
