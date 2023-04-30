namespace mementoPattern
{
    internal class DieselPickup : ICarType
    {
        public CarClass Create()
        {
            CarClass car = new()
            {
                Name = "Expedition",
                Size = "4-door crew cab pickup truck",
                Engine = "3.0 L turbo-diesel V6",
                CenterConsole = "Touch Screen /w Shmaple Car Play",
                CruiseControl = "Lane Departure Assist",
                Doors = "Normal Doors",
                EnergyCapacity = 34,
                MilesPerEnergyUnit = 24,
                AccelerationMSsquared = 4.07,
                WeightInKG = 2213,
                GVWRInKG = 3029
            };
            return car;
        }
    }
}
