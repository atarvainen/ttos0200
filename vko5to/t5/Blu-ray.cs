using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Blu_ray : StorageMedia
    {
        public string Encode { get; set; }

        public Blu_ray(double capacity, double usedcapacity, string type, string encode) : base(capacity, usedcapacity, type)
        {
            Encode = encode;
        }

        public override string ToString()
        {
            return base.ToString() + " Encode: " + Encode;
        }
    }
}
