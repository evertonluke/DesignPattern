using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.Structural
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
