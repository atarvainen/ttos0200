/*
Tehtävä 3
Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit(hertta, ruutu, risti ja pata.Numerot 1-52.) valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Shuffle(List<Card> cards)
        {
            var rnd = new Random();
            cards = cards.OrderBy(x => rnd.Next()).ToList();
        }

        static void Main(string[] args)
        {
            List<Card> cardpack = new List<Card>();
            int i = 0, j = 0;

            for (; i < 13; i++)
            {
                cardpack.Add(new Card { Number = i + 1, Type = "Heart" });
                cardpack.Add(new Card { Number = i + 1, Type = "Spade" });
                cardpack.Add(new Card { Number = i + 1, Type = "Club" });
                cardpack.Add(new Card { Number = i + 1, Type = "Diamond" });
            }

            foreach (Card card in cardpack)
            {
                Console.WriteLine("{0} kortti on {1}#{2}", ++j, card.Type, card.Number);
            }

            Shuffle(cardpack);

            j = 0;
            foreach (Card card in cardpack)
            {
                Console.WriteLine("{0} kortti on {1}#{2}", ++j, card.Type, card.Number);
            }

            Console.ReadKey();
        }
    }
}
