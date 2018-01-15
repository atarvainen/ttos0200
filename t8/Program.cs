/// @author Antti Tarvainen L4623
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
            int tmp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                    }
                }
            }
            // Array.Sort(numbers);
            Console.WriteLine("Largest number is: " +numbers[0]);
            Console.ReadKey();
        }
    }
}
