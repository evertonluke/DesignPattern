using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Structural
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configure oberver pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify obervers
            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
