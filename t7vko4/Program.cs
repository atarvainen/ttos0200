using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7vko4
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

            cd1.PrintData();
            Console.ReadKey();
        }
    }
}
