using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.RealWorld
{
    /// <summary>
    /// Template Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}
