using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class FloppyDisk : StorageMedia
    {
        public bool WriteProtection { get; set; }

        public FloppyDisk(double capacity, double usedcapacity, string type, bool writeprotection) : base(capacity, usedcapacity, type)
        {
            WriteProtection = writeprotection;
        }

        public override string ToString()
        {
            return base.ToString() + " Write protection slider: " + WriteProtection;
        }
    }
}
