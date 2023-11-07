using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.Structural
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
