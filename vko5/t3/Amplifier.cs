using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Amplifier
    {
        private int volume;

        public int Volume
        {
            get{return volume;}

            set
            {
                if (value <= 100 && value >=0)
                {
                    volume = value;
                    Console.WriteLine("-> Amplifier volume is set to : " + volume);
                }
                else if (value > 100 )
                {    
                    volume = 100;
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : 100");
                }
                
                else if (value < 0)
                {    
                    volume = 0;
                    Console.WriteLine("-> Too low volume -  Amplifier volume is set to minimum : 0");
                }
            }
        }
    }
}
