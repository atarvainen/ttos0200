/*
Tehtävä 3
Mäkihypyssä käytetään viittä arvostelutuomaria.Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.

Esimerkkitoiminta:


    Give points: 18 [Enter]
    Give points: 15 [Enter]
    Give points: 20 [Enter]
    Give points: 19 [Enter]
    Give points: 17 [Enter]
    Total points are 54
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i<5;i++)
            {
                Console.Write("Give points: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int tmp;
            for (int i = 0;i<5;i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                    }
                }
            }
            int total = numbers[1] + numbers[2] + numbers[3];
            Console.WriteLine("Total points are " + total);
            Console.ReadKey();
        }
    }
}
