using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.RealWorld
{
    // Three employee types
    public class Clerk : Employee
    {
        // Constructor
        public Clerk() : base("Kevin", 25000.0, 14)
        {
        }
    }
}
