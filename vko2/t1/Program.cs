/// @author Antti Tarvainen
/*
Tehtävä 1
Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
*/

using System;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number > ");
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
            Console.ReadKey();
        }
    }
}
