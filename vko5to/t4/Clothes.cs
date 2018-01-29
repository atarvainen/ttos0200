using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Clothes
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothes(string size, string color)
        {
            Size = size;
            Color = color;
        }

        public override string ToString()
        {
            return "Size: " + Size + " Color: " + Color;
        }
    }
}
