using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t6vko4
{
    class Vacuum
    {
        public string Model { get; set; }
        public int SuctionPower { get; set; }
        public int Suction { get; set; }
        public double Weight { get; set; }
        public int Reach { get; set; }
        public bool Power { get; set; }
        private double dust;

        public double Dust
        {
            get { return dust; }

            set
            {
                dust += value;
                Console.WriteLine("Dust bag at {0}%", dust);
            }
        }

        public void PowerOn()
        {
            Power = true;
            Console.WriteLine("Power on.");
        }

        public void PowerOff()
        {
            Power = true;
            Console.WriteLine("Power off.");
        }

        public void SetSuctionPower(int number)
        {
            Suction = SuctionPower;
            Suction = Suction / 100 * number;
            Console.WriteLine("Imuteho nyt: {0}", Suction);
        }

        public void PrintData()
        {
            Console.WriteLine("Merkki: {0}", Model);
            Console.WriteLine("Paino: {0}", Weight);
            Console.WriteLine("Imuteho: {0}W", Suction);
            Console.WriteLine("Ulottuvuus: {0}m", Reach);
            Console.WriteLine("Polypussin tila: {0}%", Dust);
        }

        public override string ToString()
        {
            
            return "Merkki: " + Model + " Teho: " + Suction + "W Paino: " + 
                Weight + "kg Ulottuvuus: " + Reach +"m.";
        }
    }
}
