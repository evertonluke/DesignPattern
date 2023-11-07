using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.Structural
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
