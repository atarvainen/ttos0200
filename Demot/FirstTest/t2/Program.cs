using System;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give point limit : ");
            short points = short.Parse(Console.ReadLine());
            if (points >= 10)
            {
                Console.WriteLine("School number is 5");
            }
            else if(points == 9 || points == 8)
            {
                Console.WriteLine("School number is 4");
            }
            else if (points == 7 || points == 6)
            {
                Console.WriteLine("School number is 3");
            }
            else if (points == 5 || points == 4)
            {
                Console.WriteLine("School number is 2");
            }
            else if (points == 3 || points == 2)
            {
                Console.WriteLine("School number is 1");
            }
            else if (points == 0 || points == 1)
            {
                Console.WriteLine("School number is 0");
            }
        }
    }
}
