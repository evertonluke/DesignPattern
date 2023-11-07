using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.RealWorld
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}