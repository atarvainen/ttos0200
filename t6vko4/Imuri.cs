using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t6vko4
{
    class Imuri
    {
        public string Merkki { get; set; }
        public int Teho { get; set; }
        public double Paino { get; set; }
        public int Ulottuvuus { get; set; }
        public bool Power { get; set; }
        private double dust;

        public double Dust
        {
            get { return dust; }

            set
            {
                /*
                if (value > )
                    Console.WriteLine("Change dust bag.");
                else
                {
                */
                    dust += value;
                    Console.WriteLine("Dust bag at {0}%", dust);
                //}
            }
        }

        public Imuri()
        {
            dust = 0;
        }

        public Imuri(string merkki, int teho,double paino,int ulottuvuus)
        {
            Merkki = merkki;
            Teho = teho;
            Paino = paino;
            Ulottuvuus = ulottuvuus;
        }

        public void poweron()
        {
            Power = true;
            Console.WriteLine("Power on.");
        }

        public void poweroff()
        {
            Power = true;
            Console.WriteLine("Power off.");
        }

        public override string ToString()
        {
            return "Merkki: " + Merkki + " Teho: " + Teho + "W Paino: " + 
                Paino + "kg Ulottuvuus: " + Ulottuvuus +"m.";
        }
    }
}
