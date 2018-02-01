using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class StorageMedia
    {
        public double Capacity { get; set; }
        public double UsedCapacity { get; set; }
        public string Type { get; set; }

        public StorageMedia(double capacity, double usedcapacity, string type)
        {
            Capacity = capacity;
            UsedCapacity = usedcapacity;
            Type = type;
        }

        public void FreeSpace()
        {
            double freespace = Capacity - UsedCapacity;
            Console.WriteLine("Free space on disk: {0} GB", freespace);
        }

        public override string ToString()
        {
            return "Type: " + Type + " Capacity: " + Capacity + " Used capacity: " + UsedCapacity;
        }
    }
}
