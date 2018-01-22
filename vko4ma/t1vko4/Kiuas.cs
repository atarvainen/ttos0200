using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1vko4
{
    class Kiuas
    {
        //properties
        public bool power;
        private int temperature;
        private int moisture;

        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value > 300)
                    Console.WriteLine("Too high temperature");
                else
                {
                    temperature = value;
                    Console.WriteLine("Temperature set to {0}", temperature);
                }
            }
        }

        public int Moisture
        {
            get { return moisture; }

            set
            {
                if (value > 100)
                    Console.WriteLine("Moisture can't be over 100%");
                else
                {
                    moisture = value;
                    Console.WriteLine("Moisture set to {0}%", moisture);
                }
            }
        }

        public void Poweron()
        {
            power = true;
            Console.WriteLine("Stove turned on");
        }

        public void Poweroff()
        {
            power = false;
            Console.WriteLine("Stove turned off");
        }
    }
}
