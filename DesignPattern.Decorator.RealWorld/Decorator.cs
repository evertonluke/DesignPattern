using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.RealWorld
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
