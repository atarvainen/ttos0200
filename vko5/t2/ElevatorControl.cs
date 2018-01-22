using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class ElevatorControl
    {
        private int floor = 1;

        public int Floor
        {
            get { return floor;}
            set
            {
                if (value >= 1 && value <= 5)
                {
                    floor = value;
                    Console.WriteLine("Elevator is now in floor : " + floor);
                }

                else if (value < 1) { Console.WriteLine("Floor is too small!"); }

                else { Console.WriteLine("Floor is too big!"); }
            }
        }
    }
}
