namespace mementoPattern
{
    internal class ElectricSedan : ICarType
    {
        public CarClass Create()
        {
            CarClass car = new()
            {
                Name = "Lumière",
                Size = "4 Door Sedan",
                Engine = "Electric",
                CenterConsole = "Touch Screen /w Shmaple Car Play",
                CruiseControl = "Full Self Driving",
                Doors = "Suicide Doors",
                EnergyCapacity = 75,
                EnergyType = "kWh",
                MilesPerEnergyUnit = 5.08,
                AccelerationMSsquared = 8.65,
                WeightInKG = 1791,
                GVWRInKG = 2180,
            };
            return car;
        }
    }
}
