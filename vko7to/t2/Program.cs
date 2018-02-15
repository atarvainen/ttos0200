/*
Tehtävä 2 - Tiedoston lukeminen ja tietojen lajittelu
Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy.Kopioi(tai luo itse vastaava tiedosto) 
D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan onko em.hakemistossa tiedostoa.Käytä File.Exist-metodia.Huomioi myös muut mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.

Esimerkkitulostus:

  Löytyi 20 riviä, ja 9 nimeä.
  Nimi Aappo esiintyy 4 kertaa
  Nimi Benkku esiintyy 2 kertaa
  Nimi Jaakko esiintyy 3 kertaa
  Nimi Wille esiintyy 4 kertaa
  Nimi Sebastian esiintyy 1 kertaa
  Nimi Cecilia esiintyy 2 kertaa
  Nimi Netta esiintyy 2 kertaa
  Nimi Matias esiintyy 1 kertaa
  Nimi Otto esiintyy 1 kertaa
  Press any key to continue . . .

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string docpath = @"D:\Temp\nimet.txt";

                if (File.Exists(docpath))
                {
                    string[] lines = System.IO.File.ReadAllLines(docpath);
                    string[] unique = lines.Distinct().ToArray();
                    Array.Sort(lines);
                    int names = lines.Count();
                    int uniquenames = unique.Count();

                    Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä.", names, uniquenames);

                    var j = lines.GroupBy( i => i );

                    foreach(var k in j)
                    {
                      Console.WriteLine( "{0} {1}", k.Key, k.Count() );
                    }
                }

                else
                {
                    Console.WriteLine("No such file exists");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
