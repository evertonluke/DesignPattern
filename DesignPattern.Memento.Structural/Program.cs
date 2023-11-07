using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento.Structural
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State      = "On";

            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento   = o.CreateMemento();

            // Continue changing originator
            o.State = "Off";

            // Restore saved state
            o.SetMemento(c.Memento);

            // Wait for user
            Console.ReadKey();
        }
    }
}
