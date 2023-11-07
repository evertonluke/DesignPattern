using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.RealWorld
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    class Shop
    {
        /// <summary>
        /// Builder uses a complex series of steps
        /// </summary>
        /// <param name="vehicleBuilder"></param>
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildWDoors();
        }
    }
}
