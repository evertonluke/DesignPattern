using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State.Structural
{
    /// <summary>
    /// State Design Pattern
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup context in a state
            var context = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
