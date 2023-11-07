using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.Structural
{
    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
