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
            try
            {
                Team kalpa = new Team("Kalpa", "Kuopio");

                Console.WriteLine(kalpa.ToString());

                kalpa.ShowPlayers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
