using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter.RealWorld
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound();
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
