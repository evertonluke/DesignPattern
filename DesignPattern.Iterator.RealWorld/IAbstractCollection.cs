using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.RealWorld
{
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
