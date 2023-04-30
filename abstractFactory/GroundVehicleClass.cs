namespace abstractFactory
{
    internal class GroundVehicleClass
    {
        private string name = "N/A";
        private string size = "N/A";
        private string engine = "N/A";
        private string centerConsole = "N/A";
        private string cruiseControl = "N/A";
        private string doors = "N/A";
        private double energyCapacity = 0;
        private string energyType = "Gallons"; // Gallons, kWh (kilowatt-hours), etc.
        private double milesPerEnergyUnit = 0; // Miles per gallon, miles per kWh, etc.
        private double accelerationMSsquared = 0; // Acceleration in meters per second squared - the rate of change of velocity with time
        private double weightInKG = 0;
        private double gvwrInKG = 0; // Gross Vehicle Weight Rating - the maximum allowable weight of a vehicle, including all fluids, cargo, passengers, and any other equipment.

        public string Name { get { return name; } set { name = value; } }
        public string Size { get { return size; } set { size = value; } }
        public string Engine { get { return engine; } set { engine = value; } }
        public string CenterConsole { get { return centerConsole; } set { centerConsole = value; } }
        public string CruiseControl { get { return cruiseControl; } set { cruiseControl = value; } }
        public string Doors { get { return doors; } set { doors = value; } }
        public double EnergyCapacity { get { return energyCapacity; } set { energyCapacity = value; } }
        public string EnergyType { get { return energyType; } set { energyType = value; } }
        public double MilesPerEnergyUnit { get { return milesPerEnergyUnit; } set { milesPerEnergyUnit = value; } }
        public double AccelerationMSsquared { get { return accelerationMSsquared; } set { accelerationMSsquared = value; } }
        public double WeightInKG { get { return weightInKG; } set { weightInKG = value; } }
        public double GVWRInKG { get { return gvwrInKG; }  set { gvwrInKG = value; } } 
        
        public GroundVehicleClass()
        {
            // default constructor
        }
        public GroundVehicleClass(GroundVehicleClass car)
        {
            // copy constructor
            Name = car.Name;
            Size = car.Size;
            Engine = car.Engine;
            CenterConsole = car.CenterConsole;
            CruiseControl = car.CruiseControl;
            Doors = car.Doors;
            EnergyCapacity = car.EnergyCapacity;
            EnergyType = car.EnergyType;
            MilesPerEnergyUnit = car.MilesPerEnergyUnit;
            AccelerationMSsquared = car.AccelerationMSsquared;
            WeightInKG = car.WeightInKG;
            GVWRInKG = car.GVWRInKG;
        }

        public override string ToString()
        {
            return $"{Name}:\n" +
                $"{Size} {Engine} with {EnergyCapacity} {EnergyType} capacity\n" +
                $"{Doors}\n" +
                $"{CenterConsole}\n" +
                $"{CruiseControl}";
        }
    }
}
