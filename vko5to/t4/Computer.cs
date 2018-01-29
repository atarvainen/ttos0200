using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Computer
    {
        public string Model { get; set; }
        public string Os { get; set; }
        public string MbModel { get; set; }

        public Computer(string model, string os, string mbmodel)
        {
            Model = model;
            Os = os;
            MbModel = mbmodel;
        }

        public override string ToString()
        {
            return "Model: " + Model + " Operating system: " + Os + " Motherboard model: " + MbModel;
        }
    }
}
