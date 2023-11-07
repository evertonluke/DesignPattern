using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.Structural
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
        public void OperationB()
        {
        }
    }
}
