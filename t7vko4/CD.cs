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
        private Song song1 = new Song("Shudder Before the Beautiful", "06:29");
        private Song song2 = new Song("Weak Fantasy", "05:23");
        private Song song3 = new Song("Elan", "04:45");
        private Song song4 = new Song("Yours Is an Empty Hope", "05:34");
        private Song song5 = new Song("Our Decades in the Sun", "06:37");
        private Song song6 = new Song("My Walden", "04:38");
        private Song song7 = new Song("Endless Forms Most Beautiful", "05:07");
        private Song song8 = new Song("Edema Ruh", "05:15");
        private Song song9 = new Song("Alpenglow", "04:45");
        private Song song10 = new Song("The Eyes of Sharbat Gula", "06:03");
        private Song song11 = new Song("The Greatest Show on Earth", "24:00");

        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public void PrintData()
        {
            Console.WriteLine("CD:");
            Console.WriteLine("-Artist: " + Artist);
            Console.WriteLine("-Name: " + Name);
            Console.WriteLine("-Genre: " + Genre);
            Console.WriteLine("-Price: {0}$", Price);
            Console.WriteLine("Songs:");
            Console.WriteLine("--- Name: {0} - {1}", song1.Name, song1.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song2.Name, song2.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song3.Name, song3.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song4.Name, song4.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song5.Name, song5.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song6.Name, song6.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song7.Name, song7.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song8.Name, song8.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song9.Name, song9.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song10.Name, song10.Duration);
            Console.WriteLine("--- Name: {0} - {1}", song11.Name, song11.Duration);
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
