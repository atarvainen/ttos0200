using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4vko4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Speed);
            Console.WriteLine(Tyres);
        }

        public override string ToString()
        {
            return Name + Speed + Tyres;
        }
    }
}
