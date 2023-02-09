using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderInterface
{
    internal class Director
    {
        private string choice = "";

        public string Choice { get { return choice; } set { choice = value; } }

        public Director(string choice) { Choice = choice; }

        public CarClass BuildCar()
        {
            if(Choice == "Electric Sedan")
            {
                ICarBuilder result = new ElectricSedanBuilder();
                result.BuildAll();
                return result.Car;
            }
            else
            {
                ICarBuilder result = new DieselPickup();
                result.BuildAll();
                return result.Car;
            }
        }
    }
}
