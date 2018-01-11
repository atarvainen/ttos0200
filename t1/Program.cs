using System;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number > ");
            int number = int.Parse(Console.ReadLine());
            if(number == 1)
            {
                Console.WriteLine("Number is one");
            }
            else if (number == 2)
            {
                Console.WriteLine("Number is two");
            }
            else if (number == 3)
            {
                Console.WriteLine("Number is three");
            }
            else
            {
                Console.WriteLine("Some other number");
            }
        }
    }
}
