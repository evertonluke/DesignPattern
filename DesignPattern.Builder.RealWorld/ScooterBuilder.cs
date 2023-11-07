using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.RealWorld
{
    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// </summary>
    class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
