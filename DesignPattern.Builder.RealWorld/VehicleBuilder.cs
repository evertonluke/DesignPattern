using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.RealWorld
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; } 
        }

        // Abstract build methos
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildWDoors();
    }
}
