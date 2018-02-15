/*
Tehtävä 1
Tee delegaateilla ohjelma, jolla käyttäjä syöttää merkkijonon. Sen jälkeen käyttäjä voi valita yhden tai useamman toiminnon jota merkkijonolle tehdään. 
Merkkijonolle pitää pystyä tekemään seuraavat toiminnot:
- muuttaa merkkijonon kaikki kirjaimet isoiksi kirjaimiksi
- muuttaa merkkijonon kaikki kirjaimet pieniksi kirjaimiksi
- muuttaa merkkijonon Otsikko-tyyllin, eli ensimmäinen merkki isolla ja loput pienellä
- kääntää merkkijonon toistepäin eli sanasta Teppo tulee oppeT.
Eli toteuta kutakin muunnosta varten oma metodi (kaikilla metodeilla täytyy olla sama signature). Luo delegaatista instanssi ja kiinnitä siihen tarvittavat metodit. Voilá.
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
        delegate string ModifyString(string input);

        static string ModifyStringToUppercase(string input)
        {
            return input.ToUpper();
        }

        static string ModifyStringToLowercase(string input)
        {
            return input.ToLower();
        }

        static string ModifyStringToHeader(string input)
        {
            char[] temp = input.ToCharArray();
            temp[0] = char.ToUpper(temp[0]);
            return new string(temp);
        }

        static string ModifyStringToReverse(string input)
        {
            int length = input.Length-1;
            char[] inputarray = input.ToCharArray();
            char[] temp = new char[1];

            for (int i = 0,j=length; i <= length/2; i++,j--)
            {
                temp[0] = inputarray[i];
                inputarray[i] = inputarray[j];
                inputarray[j] = temp[0];
            }

            return new string(inputarray);
        }

        static void WriteOut(string input, ModifyString del)
        {
            Console.WriteLine("Your string before: {0}", input);
            Console.WriteLine("Your string after: {0}", del(input));
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a string to modify: ");
            string input = "Kallel";
            do
            {
                Console.WriteLine("String to uppercase 0");
                Console.WriteLine("String to lowercase 1");
                Console.WriteLine("String to Header 2");
                Console.WriteLine("Reveres string 3");
                Console.WriteLine("Stop with enter or not a number");
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result)
                {
                    switch (number)
                    {
                        case 0:
                            {
                                WriteOut(input, new ModifyString(ModifyStringToUppercase));
                                break;
                            }
                        case 1:
                            {
                                WriteOut(input, new ModifyString(ModifyStringToLowercase));
                                break;
                            }
                        case 2:
                            {
                                WriteOut(input, new ModifyString(ModifyStringToHeader));
                                break;
                            }
                        case 3:
                            {
                                WriteOut(input, new ModifyString(ModifyStringToReverse));
                                break;
                            }
                    }
                }

                else
                {
                    break;
                }

            } while (true);
        }
    }
}
