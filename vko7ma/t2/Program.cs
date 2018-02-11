/*
Tehtävä 2
Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia. Muuta/tee toteutus, jossa CD:n sisällä olevien biisien määrää ei ole rajattu. Käsittele CD:n osalta ainakin seuraavat tiedot: nimi, artisti ja biisit.

Ohjelmoi suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olio. Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja.

Esimerkkitoiminta:


    CD data:
    - name:Endless Forms Most Beautiful
    - artist: Nightwish
    - songs:
      - Shudder Before the Beautiful, 6:29
      - Weak Fantasy, 5:23
      - Elan, 4:45
      - Yours Is an Empty Hope, 5:34
      - Our Decades in the Sun, 6:37
      - My Walden, 4:38
      - Endless Forms Most Beautiful, 5:07
      - Edema Ruh, 5:15
      - Alpenglow, 4:45
      - The Eyes of Sharbat Gula, 6:03
      - The Greatest Show on Earth, 24:00
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD();

            cd1.Artist = "Nightwish";
            cd1.Name = "Endless Forms Most Beautiful";
            cd1.Genre = "Symphonic metal";
            cd1.Price = 19.9;

            cd1.AddSong("Shudder Before the Beautiful", "6:29");
            cd1.AddSong("Weak Fantasy", "5:29");
            cd1.AddSong("Elan", "2:29");
            cd1.AddSong("Yours Is an Empty Hope", "1:29");
            cd1.AddSong("Our Decades in the Sun", "7:29");
            cd1.AddSong("My Walden", "8:29");
            cd1.AddSong("Edema Ruh", "9:29");

            Console.WriteLine(cd1.ToString());
            Console.WriteLine();
            cd1.ShowSongs();
            Console.ReadKey();
        }
    }
}
