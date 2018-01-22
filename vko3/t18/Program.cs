/*Tehtävä 8
Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int stringlength = input.Length;
            int j = 0;
            for (int i = 0; i < stringlength; i++)
            {
                if (input[i] != input[stringlength - i - 1])
                {
                    j++;
                }
            }
            if (j == 0)
                Console.WriteLine("String is palindrome.");
            else
                Console.WriteLine("String is not a palindrome.");
            Console.ReadKey();

        }
    }
}
