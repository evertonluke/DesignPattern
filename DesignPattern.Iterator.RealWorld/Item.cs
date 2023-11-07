using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.RealWorld
{
    /// <summary>
    /// A collection item
    /// </summary>
    public class Item
    {
        string name;

        public Item(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
