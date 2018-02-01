using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Ssd : StorageMedia
    {
        public string ControllerName { get; set; }

        public Ssd(double capacity, double usedcapacity, string type, string controllername) : base(capacity, usedcapacity, type)
        {
            ControllerName = controllername;
        }

        public override string ToString()
        {
            return base.ToString() + " Controller name: " + ControllerName;
        }
    }
}
