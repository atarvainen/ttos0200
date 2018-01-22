using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5vko4
{
    class Opiskelija
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Studentcode { get; set; }

        public override string ToString()
        {
            return Fname + " " + Lname + " " + Studentcode;
        }
    }
}
