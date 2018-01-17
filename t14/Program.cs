/*
Tehtävä 4
Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:

Arvosanajakauma: 
0:
1:****
2:**
3:******
4:*****
5:**

Esimerkkitoiminta:


    Give grade: 5 [Enter]
    Give grade: 5 [Enter]
    Give grade: 4 [Enter]
    Give grade: 3 [Enter]
    Give grade: 2 [Enter]
    Give grade: 1 [Enter]
    Give grade: 0 [Enter]
    Give grade: 0 [Enter]
    Grades:
    0:**
    1:*
    2:*
    3:*
    4:*
    5:**
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t14
{
    class Program
    {
        static void Main(string[] args)
        {
            int failed = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Give a grade: ");
                int number = int.Parse(Console.ReadLine()); //user input into list
                if (number == 6)    //break loop if input is 0
                {
                    break;
                }
                else
                {
                    numbers.Add(number);
                }
            }
            foreach(int number in numbers)
            {
                if (number == 5)
                    five++;
                else if (number == 4)
                    four++;
                else if (number == 3)
                    three++;
                else if (number == 2)
                    two++;
                else if (number == 1)
                    one++;
                else if (number == 0)
                    failed++;
            }
            Console.Write("0:");
            for(;failed>0;failed--)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("1:");
            for(;one>0;one--)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("2:");
            for(;two>0;two--)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("3:");
            for(;three>0;three--)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("4:");
            for(;four>0;four--)
                Console.Write("*");
            Console.WriteLine();
            Console.Write("5:");
            for(;five>0;five--)
                Console.Write("*");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
