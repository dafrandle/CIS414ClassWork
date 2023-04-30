using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    internal class AircraftClass
    {
        private string name = "N/A";
        private string configuration = "N/A";
        private int maxSpeedKnot = 0;
        private int maxAltitudeFeet = 0;
        private double fuelCapacityLiters = 0;
        private double fuelBurnLitersPerHour = 0;
        private int numberOfEngines = 0;

        public string Name { get { return name; } set { name = value; } }
        public int MaxSpeedKnot { get { return maxSpeedKnot; } set { maxSpeedKnot = value; } }
        public int MaxAltitudeFeet { get { return maxAltitudeFeet; } set { maxAltitudeFeet = value; } }
        public double FuelCapacityLiters { get { return fuelCapacityLiters; } set { fuelCapacityLiters = value; } }
        public double FuelBurnLitersPerHour { get { return fuelBurnLitersPerHour; } set { fuelBurnLitersPerHour = value; } }
        public string Configuration { get { return configuration; } set { configuration = value; } }
        public int NumberOfEngines { get { return numberOfEngines; } set { numberOfEngines = value; } }

        public AircraftClass()
        {
            // default constructor
        }

        public AircraftClass(AircraftClass plane)
        {
            // copy constructor
            Name = plane.Name;
            MaxSpeedKnot = plane.MaxSpeedKnot;
            MaxAltitudeFeet = plane.MaxAltitudeFeet;
            FuelCapacityLiters = plane.FuelCapacityLiters;
            FuelBurnLitersPerHour = plane.FuelBurnLitersPerHour;
            Configuration = plane.Configuration;
            NumberOfEngines = plane.NumberOfEngines;
        }

        public override string ToString()
        {
            return $"{Name}:\n" +
                $"Configuration: {Configuration}\n" +
                $"Max Speed: {maxSpeedKnot} knots\n" +
                $"Max Altitude: {MaxAltitudeFeet} ft\n" +
                $"Fuel Capacity: {FuelCapacityLiters} liters\n" +
                $"Fuel Burn Rate: {fuelBurnLitersPerHour} liters/h\n" +
                $"Number of Engines: {NumberOfEngines}\n";
        }
    }
}
