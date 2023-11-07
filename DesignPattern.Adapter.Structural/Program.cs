using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.Structural
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create adapter and place a request

            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
