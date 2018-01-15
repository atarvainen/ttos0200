/// @author Antti Tarvainen L4623
/*
Tehtävä 9
Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers, 0 to stop.");
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Give a number: ");
                int number = int.Parse(Console.ReadLine()); //user input into list
                if (number == 0)    //break loop if input is 0
                {
                    break;
                }
                else
                {
                    numbers.Add(number);
                }
            }
            int size = numbers.Count; //get List size
            int sum = 0;
            // sum up list numbers
            for (int i = 0; i < size;i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum is " +sum);
            /*
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            */
            Console.ReadKey();
        }
    }
}
