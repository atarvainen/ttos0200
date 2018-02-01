using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Tyre
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string TyreSize { get; set; }

        public Tyre(string model, string type, string tyresize)
        {
            Model = model;
            Type = type;
            TyreSize = tyresize;
        }
    }
}
