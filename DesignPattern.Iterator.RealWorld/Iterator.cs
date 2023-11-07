using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.RealWorld
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        Collection collection;
        int current = 0;
        int step = 1;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return current >= collection.Count; }
        }

        // Gets currente iterator item
        public Item CurrentItem
        {
            get { return collection[current] as Item; }
        }

        // Gets first item
        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            current += step;

            if (!IsDone)
            {
                return collection[current] as Item;
            }
            else
                return null;
        }

        // Gets or stes stepsize
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
    }
}
