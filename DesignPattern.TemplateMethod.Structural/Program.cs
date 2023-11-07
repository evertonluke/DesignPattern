using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.Structural
{
    /// <summary>
    /// Template Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();
        }
    }
}
