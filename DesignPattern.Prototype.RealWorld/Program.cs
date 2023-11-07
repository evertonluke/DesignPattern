using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.RealWorld
{
    /// <summary>
    /// Prototype Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();

            // Initialize with standard colors
            colorManager["red"]   = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"]  = new Color(0, 0, 255);

            // Use adds personalized colors

            colorManager["angry"] = new Color(255, 54, 0);
            colorManager["peace"] = new Color(128, 211, 128);
            colorManager["flame"] = new Color(211, 34, 20);

            // Use clones selected colors
            Color color1 = colorManager["red"].Clone()   as Color;
            Color color2 = colorManager["peace"].Clone() as Color;
            Color color3 = colorManager["flame"].Clone() as Color;

            // Wait for user
            Console.ReadKey();
        }
    }
}
