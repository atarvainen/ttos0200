/*
Tehtävä 7+
Toteuta C#:lla ohjelma, jossa List-tietorakenteeseen lisätään satunnaisesti luotuja Person-luokan oliota 10.000 kappaletta. 
Person-luokan olion etunimessä on käytettävä satunnaisesti kirjaimia väliltä A-Z ja etunimen pituus on 4 merkkiä. Sukunimi samoin, mutta pituus on 10 merkkiä.

Ohjelman tulee tulostaa henkilöiden lisäykseen kulunut aika millisekunteina. Etsi tämän jälkeen tietorakenteesta 1000 satunnaista henkilöä rekisteristä etunimen 
perusteella. Tulosta löydettyjen henkilöiden tiedot sekä hakuun yhteensä kulunut aika millisekuntteina.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //List<Person> people = new List<Person>();

                Dictionary<string, Person> people = new Dictionary<string, Person>();

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var fname = new char[4];
                var lname = new char[10];
                var random = new Random();

                Person found;

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < fname.Length; j++)
                    {
                        fname[j] = chars[random.Next(chars.Length)];
                    }
                    var finalfname = new String(fname);

                    for (int j = 0; j < lname.Length; j++)
                    {
                        lname[j] = chars[random.Next(chars.Length)];
                    }
                    var finallname = new String(lname);

                    if (people.TryGetValue(finalfname, out found))
                    {
                        
                    }
                    else
                    {
                        people.Add(finalfname, new Person { Fname = finalfname, Lname = finallname });
                    }
                }
                stopWatch.Stop();
                var time = stopWatch.ElapsedMilliseconds.ToString();

                Console.WriteLine("Time spent to add people: {0}", time);
                //3mslistalla
                //4ms dictionarylla

                stopWatch.Start();
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < fname.Length; j++)
                    {
                        fname[j] = chars[random.Next(chars.Length)];
                    }
                    var finalfname = new String(fname);

                    if (people.TryGetValue(finalfname, out found))
                    {
                        Console.WriteLine("- Found person with {0} firstname : {0} {1}", found.Fname, found.Lname);
                    }

                    /*
                    if (people.Exists(x => x.Fname == finalfname))
                    {
                        Console.WriteLine("- Found person with {0} firstname : {0} {1}", people[i].Fname, people[i].Lname);
                    }
                    */
                }
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds.ToString();

                Console.WriteLine("Time spent to find people: {0}", time);
                // 112ms listalla
                // 5ms dictionarylla
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
