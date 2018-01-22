/// @author Antti Tarvainen L4623
/*
Tehtävä 10
Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 }; //initiate array with numbers
            foreach (int number in numbers) //output HEP if number in array is even
            {
                if (number % 2 == 0)
                    Console.WriteLine("HEP");
            }
            Console.ReadKey();
        }
    }
}
