/*
Tehtävä 6

Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give distance: ");
            string line = Console.ReadLine();
            double km = 0;
            double mileage = 0.0702;
            double gasprice = 1.595;
            if (double.TryParse(line, out km))
            {
                double consume = km * mileage;
                double price = consume * gasprice;
                Console.WriteLine("Gasoline consume is " + consume + " liters and cost is " + price + " euros.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not a valid distance.");
            }
        }
    }
}
