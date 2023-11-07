using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Builder Design Pattern.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicle
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
