using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderInterface
{
    internal class CarClass
    {
        private string name = "N/A";
        private string size = "N/A";
        private string engine = "N/A";
        private string centerConsole = "N/A";
        private string cruiseControl = "N/A";
        private string doors = "N/A";
        private string energyCapacity = "N/A";

        public string Name { get { return name; } set { name = value; } }
        public string Size { get { return size; } set { size = value; } }
        public string Engine { get { return engine; } set { engine = value; } }
        public string CenterConsole { get { return centerConsole; } set { centerConsole = value; } }
        public string CruiseControl { get { return cruiseControl; } set { cruiseControl = value; } }
        public string Doors { get { return doors; } set { doors = value; } }
        public string EnergyCapacity { get { return energyCapacity; } set { energyCapacity = value; } }

        public string Description()
        {
            return $"{Name}:\n" +
                $"{Size} {Engine} with {EnergyCapacity} capacity\n" +
                $"{Doors}\n" +
                $"{CenterConsole}\n" +
                $"{CruiseControl}";
        }
    }
}
