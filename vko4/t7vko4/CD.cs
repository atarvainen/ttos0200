/*
 * Tehtävä 7
Suunnittele UML-editorilla CD-luokka, joka sisältää ominaisuuksina tyypillisiä CD-levyyn kuuluvia tietoja. Pohdi myös mitä eri 
toiminnallisuuksia CD:llä voisi olla. Toteuta ainakin toiminnallisuus, joka palauttaa kaikkien ominaisuuksien arvot yhtenä
merkkijonona (sen avulla pääohjelmassa voisi tulostaa kaikki CD:n tiedot). Tehtävässä "ei tarvitse" toteuttaa eri biisien 
ominaisuuksia, tätä asiaa pohditaan tulevissa demoissa, kun olio-ohjelmointiin liittyvä koostaminen otetaan esille. Jos 
kuitenkin haluat miettiä sitä, niin se on tämän tehtävän +kohta eli voit kokeilla tehdä erillisen Biisi-luokan ja toteuttaa 
CD-luokan sisälle taulukon, jossa on biisejä.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7vko4
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        private List<Song> songs = new List<Song>();

        public void AddSong(string name, string duration)
        {
            songs.Add(new Song(name, duration));
        }

        public override string ToString()
        {
            return "Artisti: " + Artist + " Nimi: " + Name + " Genre: " + Genre + " Hinta: " + Price;
        }

        public void PrintSongs()
        {
            foreach (Song song in songs)
                {
                    Console.Write(song.Name);
                    Console.Write(" " +song.Duration);
                    Console.WriteLine();
                }
        }

    }

    public class Song
    {
        public string Name { get; set; }
        public string Duration { get; set; }

        public Song(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }

    }
}
