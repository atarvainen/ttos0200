using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give seconds: ");
            string line = Console.ReadLine();
            int sec = 0;
            if (int.TryParse(line, out sec))
            {
                int hours = sec / 3600;
                int minutes = sec % 3600 / 60;
                int seconds = sec % 3600 % 60;
                Console.WriteLine(
                    "Seconds can be shown as " + hours + " hours " + minutes + " minutes and " + seconds + " seconds.");
            }
            Console.WriteLine();
        }
    }
}
