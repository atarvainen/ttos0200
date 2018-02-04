/*
Tehtävä 5
Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.

Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).

Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa

Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).

Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen ihminen = new Ihminen
            {
                Name = "Matti",
                Weight = 90,
                Height = 190,
                Ika = 20
            };

            Aikuinen aikuinen = new Aikuinen
            {
                Name = "Kalle",
                Weight = 80,
                Height = 170,
                Car = "Toyota",
                Ika = 40
            };

            Vauva vauva = new Vauva
            {
                Name = "Pekka",
                Weight = 6,
                Height = 40,
                Ika = 1,
                Vaippa = "Pampers"
            };

            aikuinen.Liiku();
            vauva.Liiku();
            ihminen.Liiku();

            aikuinen.Kasva();
            vauva.Kasva();
            ihminen.Kasva();

            Console.WriteLine(ihminen.ToString());
            Console.WriteLine(aikuinen.ToString());
            Console.WriteLine(vauva.ToString());
        }
    }
}
