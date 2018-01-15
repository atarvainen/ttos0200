/// @author Antti Tarvainen L4623
/*
Tehtävä 7
Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.

Algoritmi:

4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a year: ");
            string line = Console.ReadLine();
            int year = 0;
            if (int.TryParse(line, out year))
            {
                int leap = year % 4;
                int leap2 = year % 100;
                int leap3 = year % 400;
                if (leap == 0 && leap2 != 0 || leap3 == 0)
                {
                    Console.WriteLine("Year is a leap year.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Year is not a leap year.");
                    Console.ReadKey();
                }
            }
        }
    }
}
