using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Laptop : Computer
    {
        public int Weight { get; set; }
        public Laptop(string model, string os, string mbmodel, int weight) : base(model,os,mbmodel)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return base.ToString() + " Weight: " + Weight;
        }
    }
}
