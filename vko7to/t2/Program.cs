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
                    int names = lines.Length;
                    int uniquenames = unique.Length;
                    var result = lines[0].Equals(lines[4], StringComparison.Ordinal);
                    Console.WriteLine(result);

                    Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä.", names, uniquenames);
                    int i = 0;
                    
                    for (int l = 0; l < names-1;l++)
                    {
                        for (int k = 0; k < names-1; k++)
                        {
                            if (lines[l].Equals(lines[k], StringComparison.Ordinal))
                            {
                                i++;
                                Console.WriteLine(i);
                            }
                            else
                            {
                                Console.WriteLine("ei onnaa");
                            }
                        }
                    }
                    
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }

                else
                {
                    Console.WriteLine("No such file exists");
                }
            }

            catch (Exception)
            {
                throw;
            }

            Console.ReadKey();
        }
    }
}
