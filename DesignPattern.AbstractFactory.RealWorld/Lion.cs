using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.RealWorld
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildbeest
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
