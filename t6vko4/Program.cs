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
            Stopwatch stopWatch = new Stopwatch();
            Imuri miele = new Imuri("Miele", 900, 2.1, 10);
            string[] imurit = new string[1];

            imurit[0] = miele.ToString();

            foreach (string imuri in imurit)
                Console.WriteLine(imuri);

            Console.Write("Start vacuuming? yes/no ");
            string input = Console.ReadLine();
            while (true)
            {
                if (input.ToLower() == "yes")
                {
                    stopWatch.Start();
                    miele.poweron();
                    while (true)
                    {
                        Console.Write("Stop vacuuming? yes/no ");
                        string stop = Console.ReadLine();
                        if (stop.ToLower() == "yes")
                        {
                            stopWatch.Stop();
                            miele.poweroff();
                            double elapsed = stopWatch.Elapsed.TotalMilliseconds;
                            double elapsedrounded = Math.Round(elapsed / 10000, 2);
                            miele.Dust = elapsedrounded;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
