/*Tehtävä 1
Tee luokka ItMath, jolla on seuraava staattinen metodi:

Luvun tarkastaminen
bool OnkoLuku(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte 
on muunnettavissa luvuksi (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei 
hyväksytä).

Tee testausta varten luokka TestiPeti, ja sinne sopiva metodi, jolla testaat erilaisia 
vaihtoehtoja.
Alla esimerkin omainen Metodin OnkoLuku testaus kelvollisilla ja epäkelvoilla syötteillä.



Knoppikysymys:
Jos vertaat yllä olevaa kuvaa ja alla olevaa kuvaa huomaat, että opettajalta on jäänyt 
yksi tarkistus vielä tekemättä. Mikä? Miten korjaisit algoritmin?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestiPeti.Testi();
            Console.ReadKey();
        }
    }
}
