using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Konttaan");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Vaippa;
        }
    }
}
