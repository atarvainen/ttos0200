using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Shirt : Clothes
    {
        public string Style { get; set; }

        public Shirt(string size, string color, string style) : base(size,color)
        {
            Style = style;
        }

        public override string ToString()
        {
            return base.ToString() + " Style: " + Style;
        }
    }
}
