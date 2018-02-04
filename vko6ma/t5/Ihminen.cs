using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Ihminen : Nisakas
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        private int ika;

        public override int Ika
        {
            get { return ika; }
            set
            {
                ika = value;
            }
        }

        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }

        public void Kasva()
        {
            ika += 1;
        }

        public override string ToString()
        {
            return Name + " " + Weight + " " + Height + " " + Ika;
        }
    }
}
