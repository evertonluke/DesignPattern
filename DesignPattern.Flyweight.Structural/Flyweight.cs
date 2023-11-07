using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight.Structural
{
    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
