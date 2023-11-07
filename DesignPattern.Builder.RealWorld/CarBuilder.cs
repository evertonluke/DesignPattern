using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.RealWorld
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildWDoors()
        {
            vehicle["doors"] = "4";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
    }
}
