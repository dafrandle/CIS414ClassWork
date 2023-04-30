using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mementoPattern
{
    internal class CarMemento
    {
        private CarClass Car { get; set; }
        private CarOriginator Originator { get; set; }

        public CarMemento(CarOriginator originator, CarClass car)
        {
            Originator = originator;
            Car = new CarClass(car);
        }

        public void Restore()
        {
            Originator.Car = Car;
        }

        public CarClass GetCar()
        {
            return Car;
        }
    }
}
