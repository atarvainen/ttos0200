using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Aikuinen : Ihminen
    {
        public string Car { get; set; }
        
        public override void Liiku()
        {
            Console.WriteLine("Kävelen");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Car;
        }
    }
}
