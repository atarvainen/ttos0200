/*
Tehtävä 2
Toteuta pienimuotoinen MyMailBook-ohjelma, jolla voit hakea ja tallentaa tuttujesi sähköposti
(yksinkertaisuuden vuoksi oletetaan tässä että kullakin tutulla on vain yksi sähköpostiosoite). 
Luo luokka Friend, jolla on ominaisuudet Name ja Email.

Tee kokoelmaluokka MailBook, joka alustettaessa hakee tekstitiedostosta tutut.csv ja heidän sp-osoitteensa ja tallentaa ne Friend-olioihin.
Kokoelmaluokalla MailBook on readonly ominaisuus on Friends, joka palauttaa listan Friend-olioita. Toteuta pääohjelmaan ja/tai em.
MailBook-luokkaan seuraavat toiminnot:
- ohjelman käynnistyessä lukee tiedostosta tutut ja näyttää montako nimeä sai luettua
- näyttää kaikki ystävät näytöllä
- haku, jolle annetaan ystävän nimi tai sen alkuosa.Haku hakee lambda-funktiolla kaikki ystävät, joitten nimestä 
löytyy etsitty merkkijono.Huomaa että haku saattaa tuottaa yhden tai useamman tuloksen.
- uuden ystävän lisääminen, ystävän tiedot täytyy myös tallentaa em. tekstitiedostoon, huom: toteuta sopiva poikkeusten käsittely
Katso oheinen esimerkkiajo oheisessa kuvassa.
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
            MailBook mailbook = new MailBook();

            mailbook.ShowFriends();

            Console.WriteLine("Anna haettavan nimi tai sen alkuosa");
            string input = Console.ReadLine();

            mailbook.FindFriend(input);

            Console.WriteLine("Lisää tuttu");
            Console.Write("Anna tutun nimi: ");
            string friendsname = Console.ReadLine();
            Console.Write("Anna tutun email: ");
            string friendsemail = Console.ReadLine();

            mailbook.AddFriend(friendsname, friendsemail);

            Console.ReadKey();
        }
    }
}
