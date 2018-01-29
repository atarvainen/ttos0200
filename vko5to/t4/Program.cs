/*
Tehtävä 4
ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, 
puhelimia, tabletteja, läppäreitä, ... jne. Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) 
esiintyy ja käytä apua perintää, jos tavaroille löytyy yhteisiä ominaisuuksia. Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. 
Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer custom = new Computer("Custom build", "Windows", "Asus");
            Computer laptop = new Laptop("Notebook", "Linux", "Intel", 2);

            Clothes pants = new Clothes("32/32", "Blue");
            Clothes shirt = new Shirt("L", "Red", "Dress shirt");
            Clothes tshirt = new Tshirt("M", "Black", "Tshirt", "V-neck");

            Console.WriteLine(custom.ToString());
            Console.WriteLine(laptop.ToString());
            Console.WriteLine(pants.ToString());
            Console.WriteLine(shirt.ToString());
            Console.WriteLine(tshirt.ToString());
        }
    }
}
