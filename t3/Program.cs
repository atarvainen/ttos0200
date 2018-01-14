/// @author Antti Tarvainen
/*
Tehtävä 3
Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3]; //initiate 3 slot array
            for(int i=0;i<3;i++)        //3 numbers from user input
            {
                Console.Write("Give a number: ");
                numbers[i] = int.Parse(Console.ReadLine());     //output numbers into array
            }
            int numbersadded = numbers[0] + numbers[1] + numbers[2];
            int average = numbersadded / 3;
            Console.WriteLine("Added numbers: " + numbersadded + " and average: "+average);
            Console.ReadKey();
        }
    }
}
