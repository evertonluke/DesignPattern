using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Structural
{
    /// <summary>
    /// Bridge Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implemention and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
