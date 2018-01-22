/*Tehtävä 9
Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi, jossa käyttäjältä kysytään seuraavaa kirjainta. Muista näyttää aina kirjaimen jälkeen oikein arvatut 
kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei arvattujen kirjainten kohdalla). Voit näyttää myös jo arvatut ei käytetyt -kirjaimet. Päätä itse milloin pelaaja joutuu hirteen.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "vesimittari";
            StringBuilder hiddenword = new StringBuilder(11);
            hiddenword.Append("-----------");
            char inputchar;
            int lives = 20;
            Console.WriteLine("Hirsipuu.");
            while (true)
            {
                Console.Write("Arvaa kirjain: ");
                string input = Console.ReadLine();
                inputchar = input[0];
                if (word.Contains(input))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == inputchar)
                        {
                            hiddenword[i] = word[i];
                        }
                    }
                    if (hiddenword.ToString() == word)
                    {
                        Console.WriteLine("Voitit!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ei kirjainta {0}", inputchar);
                    lives--;
                }
                if (lives == 0)
                {
                    Console.WriteLine("Jouduit hirteen.");
                    break;
                }
                Console.WriteLine(hiddenword.ToString());
            }
            Console.ReadKey();
        }
    }
}