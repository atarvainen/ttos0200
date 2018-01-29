/*Tehtävä 3
Tee ohjelma joka kysyy käyttäjältä yhdestä kymmeneen lukua, niin että käyttäjä antaa luvut yhtenä 
merkkijonona pilkulla erotettuna. Siis esimerkiksi käyttäjä antaa merkkijonon "50,60,70,80,90". 
Tee luokka ItParser ja sille kolme staattista metodia. Metodeille annetaan argumenttina käyttäjän 
antama merkkijono ja metodit palauttavat tuloksen.

Toteuta metodit:
int Count(string syote) ; metodi palauttaa montako lukua annetussa merkkijonossa on
int Sum(string syote) ; metodi palauttaa merkkijonon lukujen summan
int Average(string syote) ; metodi palauttaa merkkijonon lukujen keskiarvon

Tee pääohjelma TestParser(), jolla testaat tekemiäsi metodeja erilaisilla lähtöarvoilla. Tarkista 
että metodisi varmasti palauttavat oikein eri tilanteissa.
Oheisessa kuvassa on suoritettu kaksi testiä, sekä kahdella että viidellä luvulla.
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
        static void Main(string[] args)
        {
            Console.WriteLine("Anna haluamasi lukujono merkkijonona pilkulla eroteltuna: ");
            string syote = Console.ReadLine();

            Console.WriteLine("Merkkijonossa {0} on {1} lukua, lukujen summa on {2} ja keskiarvo on {3}", syote, ItParser.Count(ItParser.Split(syote)), ItParser.Sum(ItParser.Split(syote)), ItParser.Average(ItParser.Split(syote)));

            Console.ReadKey();
        }
    }
}