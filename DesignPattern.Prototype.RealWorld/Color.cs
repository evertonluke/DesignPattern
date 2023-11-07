using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.RealWorld
{
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        /// <summary>
        /// Create a shallow copy
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3}, {1,3}, {2, 3}", red, green, blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
