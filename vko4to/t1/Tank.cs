using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Tank
    {
        public string Name { get; set; }
        public string Type { get; set; }

        private readonly float SpeedMax = 100;

        private float speed;

        private int crewcount;

        public int CrewCount
        {
            get
            {
                return crewcount;
            }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    crewcount = value;
                }

                else
                {
                    Console.WriteLine("Crewcount not set");
                }
            }
        }

        public float Speed
        {
            get { return speed; }
        }

        public void AccelerateTo(float number)
        {
            if (number >= 0 && number <= SpeedMax)
            {
                speed = number;
                Console.WriteLine("Speed set to: " + speed);
            }
        }

        public void SlowTo(float number)
        {
            if (number >= 0 && number <= SpeedMax)
            {
                speed = number;
                Console.WriteLine("Speed set to: " + speed);
            }
        }
    }
}
