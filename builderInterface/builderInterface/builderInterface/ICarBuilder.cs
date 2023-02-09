using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderInterface
{
    internal interface ICarBuilder
    {
        CarClass Car { get; set; }
        public void Reset();
        public void BuildName();
        public void BuildSize();
        public void BuildEngine();
        public void BuildCenterConsole();
        public void BuildCruiseControl();
        public void BuildDoors();
        public void BuildEnergyCapacity();

        public void BuildAll()
        {
            BuildName();
            BuildSize();
            BuildEngine();
            BuildCenterConsole();
            BuildCruiseControl();
            BuildDoors();
            BuildEnergyCapacity();
        }

    }
}
