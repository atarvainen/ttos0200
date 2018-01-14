/// @author Antti Tarvainen
/*
Tehtävä 8
Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.WriteLine("Give 3 numbers.");
            //fill array with numbers from user input
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Give a number: ");
                string line = Console.ReadLine();
                int.TryParse(line, out numbers[i]);
            }
            Array.Sort(numbers);
            Console.WriteLine("Largest number is: " +numbers[2]);
            Console.ReadKey();
        }
    }
}
