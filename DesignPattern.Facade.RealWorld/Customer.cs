using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade.RealWorld
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
