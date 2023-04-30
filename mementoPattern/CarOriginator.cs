using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mementoPattern
{
    internal class CarOriginator
    {
        private CarClass car = new();

        public CarClass Car
        {
            get { return car; }
            set { car = value; }
        }

        public CarOriginator(ICarType input)
        {
            Car = input.Create();
        }

        public CarOriginator(CarClass input)
        {
            Car = input;
        }

        public CarOriginator()
        {
            Car = new DefaultCarType().Create();
        }

        public CarOriginator(CarOriginator input)
        {
            Car = input.Car;
        }

        public CarMemento CreateMemento()
        {
            return new CarMemento(this, Car);
        }
    }
}
