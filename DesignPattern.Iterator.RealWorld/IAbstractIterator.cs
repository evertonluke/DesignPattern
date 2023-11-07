using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.RealWorld
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone {  get; }
        Item CurrentItem {  get; }
    }
}
