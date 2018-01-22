using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;

            string line = Console.ReadLine();

            bool result = Double.TryParse(line, out number);

            if (result)
            {
                Console.WriteLine("Success: "+number);
            }

            else
            {
                Console.WriteLine("Nan");
            }

            Console.ReadKey();
        }
    }
}