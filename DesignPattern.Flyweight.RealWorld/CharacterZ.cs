using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.RealWorld
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            symbol  = 'Z';
            height  = 100;
            width   = 100;
            ascent  = 68;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            
            Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
        }
    }
}
