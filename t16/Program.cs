/*
 * Tehtävä 6
Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen 
jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta 
tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators.

Esimerkkitoiminta:


    Guess a number: 50 [Enter]
    Number is bigger
    Guess a number: 75 [Enter]
    Number is smaller
    Guess a number: 66 [Enter]
    Great, it takes a 3 guesses!
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int number = rnd.Next(1, 100);
            int i = 0;
            while (true)
            {
                Console.Write("Guess a number: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Number is smaller");
                    i++;
                    continue;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Number is bigger");
                    i++;
                    continue;
                }
                else if (guess == number)
                {
                    i++;
                    Console.WriteLine("Great, it took you {0} guesses", i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
