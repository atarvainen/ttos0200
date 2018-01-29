using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Radio
    {
        public bool Power { get; set; }
        private int volume;
        private double channel;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    volume = 0;
                    Console.WriteLine("Volume set to: " + volume);
                }
                else if (value > 10)
                {
                    volume = 10;
                    Console.WriteLine("Volume set to: " + volume);
                }
                else
                {
                    volume = value;
                    Console.WriteLine("Volume set to: " + volume);
                }
            }
        }

        public double Channel
        {
            get { return channel; }
            set
            {
                if (value < 2000.0)
                {
                    channel = 2000.0;
                    Console.WriteLine("Channel set to: " + channel);
                }
                else if (value > 26000.0)
                {
                    channel = 26000.0;
                    Console.WriteLine("Channel set to: " + channel);
                }
                else
                {
                    channel = value;
                    Console.WriteLine("Channel set to: " + channel);
                }
            }
        }

        public void PowerOn()
        {
            Power = true;
            Console.WriteLine("Power on");
        }

        public void PowerOff()
        {
            Power = false;
            Console.WriteLine("Power off");
        }
    }
}
