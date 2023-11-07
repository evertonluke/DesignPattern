using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.RealWorld
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
