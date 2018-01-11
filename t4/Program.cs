using System;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikasi: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}
