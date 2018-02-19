/*
Tehtävä 3 - Kalat
Toteuta sovellus MyFishApp, jossa voit hallita kalastukseen liittyviä tietoja. Ohjelman pitää pystyä käsittelemään:kalastajan perustiedot (nimi, puhelinnumero), 
saadun kalan perustiedot (laji, pituus ja paino), sekä kalapaikan perustiedot (nimi ja paikka). Suunnittele tarvittava luokkarakenne, ja piirrä siitä UML-kaavio. 
Toteuta pääohjelma MyFishApp, jossa käyttäjä voi lisätä kalastajia ja heidän saamiansa kaloja. Tee toiminto jolla voi tulostaa kalarekisterin sisältö eli kaikkien kalastajien saamat kaikki kalat.

Esimerkkitulostus:


    A new fisherman added to Fish-register:
     - Fisherman: Kirsi Kernel Phone: 020-12345678

    Fisher : Kirsi Kernel got a new fish
     - specie : pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

    Fisher : Kirsi Kernel got a new fish
     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

    All fish in register:

    Fisherman Kirsi Kernel has got following fish:

     - specie: pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

    Press enter key to continue...   

Ja lopuksi toteuta kalarekisterille toiminto, että kalat voidaan tulostaa suuruusjärjestykessä (painavin ensin).


    Sorted register

    *** All fish in Fish-register: ***

     - Salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland
	 - Fisherman: Kirsi Kernel

     - Pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä
	 - Fisherman: Kirsi Kernel	 

     - Crucian carp 20 cm 0,4 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä
	 - Fisherman: Uolevi Kärppä
     
    Press enter key to continue...   
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
        static void AddFishingSpot(List<FishingSpot> list, string name, string place)
        {
            list.Add(new FishingSpot { Name = name, Place = place });
        }
        static void AddFisher(List<Fisher> list, string name, string puh)
        {
            list.Add(new Fisher { Name = name, Phone = puh });
            Console.WriteLine("A new fisherman added to Fish-register:");
            Console.WriteLine("- Fisherman: {0} Phone: {1}", name, puh);
        }
        static void Main(string[] args)
        {
            List<Fisher> fishers = new List<Fisher>();

            List<FishingSpot> fishingSpots = new List<FishingSpot>();

            while (true)
            {
                Console.WriteLine("Add a fisher 0");
                Console.WriteLine("Add a fish for a fisher 1");
                Console.WriteLine("Add a fishingspot 2");
                Console.WriteLine("Print caught fishes 3");
                bool result = int.TryParse(Console.ReadLine(), out int number);
                if (result)
                {
                    switch (number)
                    {
                        case 0:
                            {
                                Console.WriteLine("Give fishers name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Give fishers phone: ");
                                string phone = Console.ReadLine();
                                AddFisher(fishers, name, phone);
                                break;
                            }
                        case 1:
                            {
                                int width = 0;
                                float weight = 0;
                                Console.Write("Give the name of the fisher who fished the fish: ");
                                string name = Console.ReadLine();
                                int found = fishers.FindIndex(x => x.Name == name);
                                Console.Write("Give specie of the fish: ");
                                string specie = Console.ReadLine();
                                Console.Write("Give width of the fish: ");
                                bool result2 = int.TryParse(Console.ReadLine(), out int number2);
                                if (result2)
                                {
                                    width = number2;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number or in wrong format");
                                    continue;
                                }
                                Console.Write("Give weight of the fish: ");
                                bool result3 = float.TryParse(Console.ReadLine(), out float number3);
                                if (result3)
                                {
                                    weight = number3;
                                }
                                else
                                {
                                    Console.WriteLine("Not a number or in wrong format");
                                    continue;
                                }
                                Console.Write("Give the name of the place where the fish was fished: ");
                                string place = Console.ReadLine();
                                int placefound = fishingSpots.FindIndex(x => x.Name == place);
                                fishers[found].AddFish(specie, width, weight, fishingSpots[placefound].Name, fishingSpots[placefound].Place);
                                
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Give fishingspots name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Give fishingspots place: ");
                                string place = Console.ReadLine();
                                AddFishingSpot(fishingSpots, name, place);
                                break;
                            }
                        case 3:
                            {
                                foreach (Fisher f in fishers)
                                {
                                    f.ShowFishes();
                                }

                                break;
                            }
                    }
                } 
            }
        }
    }
}
