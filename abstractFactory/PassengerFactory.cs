namespace abstractFactory
{
    internal class PassengerFactory : IVehicleFactory
    {
        public PassengerFactory() { }
        public GroundVehicleClass CreateGroundVehicle()
        {
            return new GroundVehicleClass()
            {
                Name = "Mercedes-Benz Sprinter 4500",
                Size = "High Roof Van",
                Engine = "2.0L In-line v4 Diesel",
                CenterConsole = "Standard Console",
                CruiseControl = "Normal Cruise Control",
                Doors = "Sliding Doors",
                EnergyCapacity = 24.5,
                EnergyType = "Gallons",
                MilesPerEnergyUnit = 15,
                AccelerationMSsquared = 2.23,
                WeightInKG = 2420,
                GVWRInKG = 3080
            };
        }
        public AircraftClass CreateAircraft()
        {
            return new AircraftClass()
            {
                Name = "Piper PA-28-180 Cherokee",
                MaxSpeedKnot = 160,
                MaxAltitudeFeet = 18000,
                FuelCapacityLiters = 56,
                FuelBurnLitersPerHour = 10,
                Configuration = "Passenger",
                NumberOfEngines = 1
            };
        }
    }
}