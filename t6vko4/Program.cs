/*
 * Tehtävä 6
Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla. Tee uusi projekti. Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa 
edellisten tehtävien mukaisesti.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace t6vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            int vacuumchoice = 0;
            Stopwatch stopWatch = new Stopwatch();

            List<Vacuum> vacuums = new List<Vacuum>
            {
                new Vacuum(){Model = "Miele", SuctionPower= 900,Weight= 2.10,Reach= 12},
                new Vacuum(){Model = "Electrolux", SuctionPower= 700,Weight= 1.90,Reach= 10}
            };

            //new List with object values as string
            List<string> vacuumstats =new List<string>();


            //add string values to list
            foreach (Vacuum vacuum in vacuums)
                {
                    vacuumstats.Add(vacuums[i].ToString());
                    i++;
                }

            //Display vacuums stats
           foreach (string vacuum in vacuumstats)
                {
                    Console.Write("{0} ", j);
                    Console.WriteLine(vacuum);
                    j++;
                }

            Console.WriteLine();
            Console.Write("Valitse imuri 1-{0}: ", i);
            bool result = int.TryParse(Console.ReadLine(), out int number);
            vacuumchoice = number -1;

            if (result)
            {
                Console.WriteLine("Valitsit imurin: {0}", vacuumstats[vacuumchoice]);
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Tulosta imurin tiedot 1");
                    Console.WriteLine("Aloita imurointi      2");
                    Console.WriteLine("Lopeta                3");
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            {
                                Console.WriteLine(vacuumstats[vacuumchoice]);
                                continue;
                            }

                        case 2:
                            {
                                while (true)
                                {
                                        stopWatch.Start();
                                        vacuums[vacuumchoice].PowerOn();
                                        while (true)
                                        {
                                            Console.Write("Lopeta imurointi? yes/no ");
                                            string stop = Console.ReadLine();

                                            if (stop.ToLower() == "yes")
                                            {
                                                stopWatch.Stop();
                                                vacuums[vacuumchoice].PowerOff();
                                                double elapsed = stopWatch.Elapsed.TotalMilliseconds;
                                                double elapsedrounded = Math.Round(elapsed / 10000, 2);
                                                vacuums[vacuumchoice].Dust = elapsedrounded;
                                                Console.WriteLine();
                                                break;
                                            }
                                            else
                                                continue;

                                        }break;
                                }break;
                            }

                        case 3:
                            return;
                    }
                }
            }

           Console.ReadKey();
        }
    }
}
