/*
Tehtävä 4 - luvut tiedostoihin
Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut. Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla.

Esimerkkitulostus:


    Give a number (enter or not a number ends) : 1,0
    Give a number (enter or not a number ends) : 2,0
    Give a number (enter or not a number ends) : 3,0
    Give a number (enter or not a number ends) : 4
    Give a number (enter or not a number ends) : 5
    Give a number (enter or not a number ends) : 6
    Give a number (enter or not a number ends) :
    
    Contents of T2Integers.txt:
    4
    5
    6

    Contents of T2Doubles.txt:
    1,0
    2,0
    3,0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter outputFile = new System.IO.StreamWriter("int.txt");
            StreamWriter secondOutputFile = new System.IO.StreamWriter("double.txt");
            double number;
            string line;
            do
            {
                try 
	            {	        
		            Console.Write("Give a number (enter or not a number ends) : ");
                    line = Console.ReadLine();
                    bool result = double.TryParse(line, out number);
                    if (result)
                    {
                        if (number % 1 == 0)
                        {
                            outputFile.WriteLine(number);
                        }

                        else
                        {
                            secondOutputFile.WriteLine(number);
                        }
                    }

                    else
                    {
                        break;
                    }
	            }

	            catch (Exception ex)
	            {
		            Console.WriteLine(ex);
	            }

            }while (line.Length > 0);

            outputFile.Close();
            secondOutputFile.Close();
        }
    }
}
