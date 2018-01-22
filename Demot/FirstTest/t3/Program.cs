using System;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.Write("Anna kolme lukua");
            for(int i=0;i<3;i++)
                numbers[i] = int.Parse(Console.ReadLine());
            int numbersadded = numbers[0] + numbers[1] + numbers[2];
            int median = numbersadded / 3;
            Console.WriteLine(numbersadded) ;
            Console.WriteLine(median);
        }
    }
}
