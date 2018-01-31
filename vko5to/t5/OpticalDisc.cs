using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    public class OpticalDisc
    {
        public int Capacity { get; set; }
        public int UsedCapacity { get; set; }
        public string Type { get; set; }

        public OpticalDisc(int capacity, int usedcapacity, string type)
        {
            Capacity = capacity;
            UsedCapacity = usedcapacity;
            Type = type;
        }

        public void FreeSpace()
        {
            int freespace = Capacity - UsedCapacity;
            Console.WriteLine("Free space on disk: {0} GB", freespace);
        }

        public override string ToString()
        {
            return "Type: " + Type + " Capacity: " + Capacity + " Used capacity: " + UsedCapacity;
        }
    }
}
