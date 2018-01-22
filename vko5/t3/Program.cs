/*

Tehtävä 3

Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida 
äänenvoimakkuutta välillä 0-100. Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot 
olion Vahvistin-luokasta.Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla.

Käytä Vahvistin-luokassa get- ja set-aksessoreita.get-aksessori palauttaa 
äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Amplifier amp = new Amplifier();
            while (true)
            {
                Console.Write("Give a new volume value (0-100) > ");
                bool result = Int32.TryParse(Console.ReadLine(), out number);
                if (result)
                    amp.Volume = number;
                else
                {
                    Console.WriteLine("NaN");
                    continue;
                }
            }
        }
    }
}
