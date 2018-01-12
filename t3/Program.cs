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
            int[] numbers = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.Write("Give a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int numbersadded = numbers[0] + numbers[1] + numbers[2];
            int average = numbersadded / 3;
            Console.WriteLine("Added numbers: " + numbersadded + " and average: "+average);
            Console.ReadKey();
        }
    }
}
