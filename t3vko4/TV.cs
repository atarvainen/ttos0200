using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3vko4
{
    class TV
    {
        public int Channel { get; set; }
        public int Contrast { get; set; }
        public int Brightness { get; set; }
        public bool Power { get; set; }

        public TV()
        {
            Channel = 1;
            Brightness = 100;
            Contrast = 50;
            Power = false;
        }

        public void ChannelUp()
        {
            Channel += 1;
            Console.WriteLine("Channel changed to {0}", Channel);
        }

        public void ChannelDown()
        {
            Channel -= 1;
            Console.WriteLine("Channel changed to {0}", Channel);
        }

        public void ContrastUp()
        {
            Contrast += 5;
            Console.WriteLine("Channel changed to {0}", Contrast);
        }

        public void ContrastDown()
        {
            Contrast -= 5;
            Console.WriteLine("Channel changed to {0}", Contrast);
        }

        public void BrightnessUp()
        {
            Brightness += 5;
            Console.WriteLine("Channel changed to {0}", Brightness);
        }

        public void BrightnessDown()
        {
            Brightness -= 5;
            Console.WriteLine("Channel changed to {0}", Brightness);
        }

        public void Poweron()
        {
            Power = true;
            Console.WriteLine("TV turned on");
        }

        public void Poweroff()
        {
            Power = false;
            Console.WriteLine("TV turned off");
        }
    }
}
