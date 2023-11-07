using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.RealWorld
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
