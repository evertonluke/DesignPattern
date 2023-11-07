using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.RealWorld
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");            
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
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
