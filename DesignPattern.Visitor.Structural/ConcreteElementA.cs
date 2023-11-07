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
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA()
        {
        }
    }
}
