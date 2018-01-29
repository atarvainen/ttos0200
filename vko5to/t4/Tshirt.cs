using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Tshirt : Shirt
    {
        public string Neck { get; set; }

        public Tshirt(string size, string color, string style, string neck) : base(size,color,style)
        {
            Neck = neck;
        }

        public override string ToString()
        {
            return base.ToString() + " Neck: " + Neck;
        }
    }
}
