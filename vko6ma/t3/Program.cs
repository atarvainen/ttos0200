/*
Tehtävä 3
Jääkiekon SM-liigassa on viisitoista joukkuetta ja jokaisessa joukkuuessa on noin 25 pelaajaa. Tee Pelaaja-luokka, jolla on ominaisuudet: 
etunimi, sukunimi, pelipaikka (mv, p, h), kätisyys (L tai R). Luo myös luokka Seura, jolla on ominaisuudet: nimi, kaupunki ja kokoelma Pelaaja-olioita. 
Tee konsoli sovellus, joka osaa esittää valitun seuran pelaajat. Voit "kovakoodata" pelaajatiedot pelaajaolioihin.

Tehtävä 4+
Jatkoa edelliseen. Mihin ja miten tallentaisit pelaajien tiedot siksi aikaa kun ohjelma ei käynnissä? Toteuta valitsemasi ratkaisu.
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
            Seura ducks = new Seura("Ducks", "Anaheim");

            List<Pelaaja> players = new List<Pelaaja>();

            players.Add(new Pelaaja("Kevin", "Bieksa", "P", "R"));
            players.Add(new Pelaaja("Chris", "Wagner", "H", "R"));
            players.Add(new Pelaaja("Reto", "Berra", "MV", "R"));

            foreach (Pelaaja player in players)
            {
                ducks.playersInTeam.Add(player);
            }

            Console.WriteLine(ducks.ToString());
            ducks.GetPlayersInfo();

            ducks.SaveData();
        }
    }
}
