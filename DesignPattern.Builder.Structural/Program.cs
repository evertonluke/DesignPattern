using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Builder Design Pattern.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Create director and builders
            Director director = new Director();
            Builder b1        = new ConcreteBuilder1();
            Builder b2        = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
