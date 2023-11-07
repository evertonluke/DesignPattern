using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.Structural
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        // Gets current iteration item
        public override object CurrentItem()
        {
            return aggregate[current];
        }

        // Gets first iteration item
        public override object First()
        {
            return aggregate[0];
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }

        // Gets next iteration item
        public override object Next()
        {
            object ret = null;

            if (current < aggregate.Count -1) 
            {
                ret = aggregate[++current];
            }

            return ret;
        }
    }
}
