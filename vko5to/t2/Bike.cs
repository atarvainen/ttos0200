using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike(string name, string model, int year, string color, bool gearWheels, string gearName) : base(name, model, year, color)
        {
            GearWheels = gearWheels;
            GearName = gearName;
        }

        public override string ToString()
        {
            return base.ToString() + " GearWheels: " + GearWheels + " GearModel: " + GearName;
        }
    }
}
