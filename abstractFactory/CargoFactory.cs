using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    internal class CargoFactory : IVehicleFactory
    {
        public CargoFactory() { }
        public GroundVehicleClass CreateGroundVehicle()
        {
            return new GroundVehicleClass()
            {
                Name = "Peterbilt 389",
                Size = "Tractor-Trailer",
                Engine = "15.0L In-line v6 Diesel",
                CenterConsole = "Standard Console",
                CruiseControl = "Normal Cruise Control",
                Doors = "Normal Doors",
                EnergyCapacity = 135,
                EnergyType = "Gallons",
                MilesPerEnergyUnit = 8,
                AccelerationMSsquared = 0.4,
                WeightInKG = 18000,
                GVWRInKG = 40000
            };
        }

        public AircraftClass CreateAircraft()
        {
            return new AircraftClass()
            {
                Name = "Boeing 747-400",
                MaxSpeedKnot = 650,
                MaxAltitudeFeet = 45000,
                FuelCapacityLiters = 250000,
                FuelBurnLitersPerHour = 120,
                Configuration = "Cargo",
                NumberOfEngines = 4
            };
        }
    }
}
