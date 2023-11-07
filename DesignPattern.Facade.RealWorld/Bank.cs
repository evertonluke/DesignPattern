using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade.RealWorld
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
