using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2vko4
{
    class Pesukone
    {
        private int watertemp;
        private int slingspeed;
        public bool Power { get; set; }
        public bool Wash { get; set; }

        public int WaterTemp
        {
            get { return watertemp; }
            set
            {
                if (value > 90)
                    Console.WriteLine("Too high temperature");
                else
                {
                    watertemp = value;
                    Console.WriteLine("Water temperature set to {0}", watertemp);
                }
            }
        }

        public int Slingspeed
        {
            get { return slingspeed; }
            set
            {
                if (value > 1200)
                    Console.WriteLine("Too high slingspeed");
                else
                {
                    slingspeed = value;
                    Console.WriteLine("Slingspeed set to {0}", slingspeed);
                }
            }
        }

        public Pesukone()
        {
            watertemp = 60;
            slingspeed = 800;
        }

        public void AddWaterTemp()
        {
            watertemp += 10;
            Console.WriteLine("Water temp set to {0}C", watertemp);
        }

        public void SubstractWaterTemp()
        {
            watertemp -= 10;
            Console.WriteLine("Water temp set to {0}C", watertemp);
        }

        public void AddSlingSpeed()
        {
            slingspeed += 100;
            Console.WriteLine("Sling speed set to {0}", slingspeed);
        }

        public void SubstractSlingSpeed()
        {
            slingspeed -= 100;
            Console.WriteLine("Sling speed set to {0}", slingspeed);
        }

        public void Poweron()
        {
            Power = true;
            Console.WriteLine("Washing machine turned on");
        }

        public void Poweroff()
        {
            Power = false;
            Console.WriteLine("Washing machine turned off");
        }

        public void StartWash()
        {
            Wash = true;
            Console.WriteLine("Wash started.");
        }

        public void StopWash()
        {
            Wash = false;
            Console.WriteLine("Wash ended.");
        }
    }
}
