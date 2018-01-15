/// @author Antti Tarvainen  L4623
/*
Tehtävä 1
Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
*
**
***
****
*****
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0;i < number;i++)
            {
                for (int e = 0; e <= i;e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
