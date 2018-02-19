using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Dice
    {
        public int Sides { get; set; }

        public Dice()
        {
            Sides = 7;
        }

        public int RollDice()
        {
            Random rnd = new Random();

            int random = rnd.Next(1, this.Sides);

            return random;
        }
    }
}
