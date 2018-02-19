/*
Tehtävä 1 - Noppa
Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. 
Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, 
että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen keskiarvo.

Esimerkkitulostus:

    Dice, one test throw value is 4
    MarkupCopy

    How many times you want to throw a dice :  10000
    Dice is now thrown 10000 times, average is 3,4853
    MarkupCopy
Tulosta lopuksi kaikkien heitettyjen lukujen esiintymismäärät.


    How many times you want to throw a dice :  10000

    Dice is now thrown 10000 times
    - average is 3,4853
    - 1 count is 1726
    - 2 count is 1610
    - 3 count is 1705
    - 4 count is 1691
    - 5 count is 1580
    - 6 count is 1688

    Press enter key to continue...
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            List<int> rolls = new List<int>();

            Console.WriteLine(dice.RollDice());

            Console.Write("How many times do you want to throw a dice: ");
            bool result = int.TryParse(Console.ReadLine(), out int number);
            if (result)
            {
                for (int i = 0; i < number;i++)
                {
                    rolls.Add(dice.RollDice());
                }

                Console.WriteLine("Dice was thrown {0} times", number);
                Console.WriteLine("Average is {0}", rolls.Average());

                rolls.Sort();
                var j = rolls.GroupBy(i => i);

                foreach (var k in j)
                {
                    Console.WriteLine("{0} count is {1}", k.Key, k.Count());
                }
            }

            else
            {
                Console.WriteLine("Not a number!");
            }
            Console.ReadKey();
        }
    }
}
