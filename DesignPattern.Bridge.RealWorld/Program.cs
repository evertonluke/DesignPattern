using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.RealWorld
{
    /// <summary>
    /// Bridge Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction
            var customers = new Customers();

            // Set ConcreteImplementor
            customers.Data = new CustomersData("Chicago");

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Add("Henry Velasquez");
            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}
