using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderInterface
{
    internal class DieselPickup : ICarBuilder
    {
        private CarClass car = new();

        public CarClass Car { get { return car; } set { car = value; } }

        public void Reset()
        {
            Car = new CarClass();
        }

        public void BuildName()
        {
            Car.Name = "Expedition";
        }
        public void BuildSize()
        {
            Car.Size = "4-door crew cab pickup truck";
        }
        public void BuildEngine()
        {
            Car.Engine = "3.0 L turbo-diesel V6";
        }
        public void BuildCenterConsole()
        {
            Car.CenterConsole = "Touch Screen /w Shmaple Car Play";
        }
        public void BuildCruiseControl()
        {
            Car.CruiseControl = "Lane Departure Assist";
        }
        public void BuildDoors()
        {
            Car.Doors = "Normal Doors";
        }
        public void BuildEnergyCapacity()
        {
            Car.EnergyCapacity = "34 Gal. Tank";
        }

    }
}
