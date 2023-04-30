using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    internal interface IVehicleFactory
    {
        GroundVehicleClass CreateGroundVehicle();
        AircraftClass CreateAircraft();
    }
}
