/*
Tehtävä 5 - oliot levylle
Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), 
alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. Luo pääohjelmassa muutamia TV-ohjelmaolioita 
(tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle. 
Mieti käytätkö jotain tietorakennetta apunasi. Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace t5
{
    class Program
    {
        static void ReadFile(List<TVShow> tvshows)
        {
            try
	        {
                IFormatter formatter = new BinaryFormatter();

		        using(Stream openStream = new FileStream("TV_Shows.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    tvshows = (List<TVShow>)formatter.Deserialize(openStream);
                }
                    
                foreach (TVShow show in tvshows)
                {
                    Console.WriteLine("Show name: {0}, Channel: {1}, Starting time: {2}, Ending time: {3}, Info: {4}", show.ShowName, show.Channel, show.StartingTime, show.EndingTime, show.Info);
                }
	        }

	        catch (Exception)
	        {
		        throw;
	        }
        }

        static void SaveToFile(List<TVShow> tvshows)
        {
            try
	        {	        
		        tvshows.Add(new TVShow { ShowName = "Frendit", Channel = "Sub", StartingTime = new DateTime(2018, 6, 1, 12, 30, 00), EndingTime = new DateTime(2018, 6, 1, 13, 00, 00), Info = "Sarja kaveruksista" });
                tvshows.Add(new TVShow { ShowName = "Simpsons", Channel = "Mtv3", StartingTime = new DateTime(2018, 6, 1, 14, 30, 00), EndingTime = new DateTime(2018, 6, 1, 15, 00, 00), Info = "Sarja keltaisista hepuista" });
                tvshows.Add(new TVShow { ShowName = "Futurama", Channel = "Nelonen", StartingTime = new DateTime(2018, 6, 1, 15, 30, 00), EndingTime = new DateTime(2018, 6, 1, 16, 00, 00), Info = "Sarja Simpsonien tekijöiltä" });

                IFormatter formatter = new BinaryFormatter();

                using(Stream openStream = new FileStream("TV_Shows.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    formatter.Serialize(writeMultipleStream, tvshows);
                }

                foreach (TVShow show in tvshows)
                {
                    Console.WriteLine("Show name: {0}, Channel: {1}, Starting time: {2}, Ending time: {3}, Info: {4}", show.ShowName, show.Channel, show.StartingTime, show.EndingTime, show.Info);
                }
	        }

	        catch (Exception)
	        {

		        throw;
	        }
        }

        static void Main(string[] args)
        {
            List<TVShow> tvshows = new List<TVShow>();

            if (File.Exists("TV_Shows.bin"))
            {
                ReadFile(tvshows);
            }

            else
            {
                SaveToFile(tvshows);
            }

            Console.ReadKey();
        }
    }
}
