using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade.Structural
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
