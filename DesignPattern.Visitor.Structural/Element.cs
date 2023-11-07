using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.Structural
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
