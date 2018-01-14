/// @author Antti Tarvainen
/*
Tehtävä 4
Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, 
tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
*/

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
