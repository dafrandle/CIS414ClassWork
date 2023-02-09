using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderInterface
{
    internal class ElectricSedanBuilder : ICarBuilder
    {
        private CarClass car = new();

        public CarClass Car { get { return car; } set { car = value; } }

        public void Reset()
        {
            Car = new CarClass();
        }

        public void BuildName()
        {
            Car.Name = "Lumière";
        }
        public void BuildSize()
        {
            Car.Size = "4 Door Sedan";
        }
        public void BuildEngine()
        {
            Car.Engine = "Electric";
        }
        public void BuildCenterConsole()
        {
            Car.CenterConsole = "Touch Screen /w Shmaple Car Play";
        }
        public void BuildCruiseControl()
        {
            Car.CruiseControl = "Full Self Driving";
        }
        public void BuildDoors()
        {
            Car.Doors = "Suicide Doors";
        }
        public void BuildEnergyCapacity()
        {
            Car.EnergyCapacity = "100 kWh Battery";
        }

    }
}
