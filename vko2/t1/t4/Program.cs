using System;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.Write("Anna ikasi: ");
            string age = Console.ReadLine();
            bool isString = int.TryParse(age, out result);
        }
    }
}
