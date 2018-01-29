using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            string syote = "01.01.2017";
            Console.WriteLine(ItMath.OnkoPvm(syote));
            Console.ReadKey();
        }
    }
}
