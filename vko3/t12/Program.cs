/// @author Antti Tarvainen L4623
/*
Tehtävä 2
Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.

Esimerkkitoiminta:


    Give a number: 1 [Enter]
    Give a number: 2 [Enter]
    Give a number: 3 [Enter]
    Give a number: 4 [Enter]
    Give a number: 5 [Enter]
    Number are 5,4,3,2,1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i =0;i<5;i++)
            {
                Console.Write("Give a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int tmp;
            for (int e = 0 ; e < 5 ; e++)
            {
                for (int j = 0; j < e; j++)
                {
                    if (numbers[j] < numbers[e])    //if number[0] is smaller than number[1]
                    {
                        tmp = numbers[e];           //copy value from numbers[1] to tmp
                        numbers[e] = numbers[j];    //replace numbers[1] with numbers[0]
                        numbers[j] = tmp;           //replace numbers[0] with tmp which has number[1] value
                    }
                }
            }
            foreach (int number in numbers) //print arrays numbers on console
            {
                Console.Write(number);
            }
            Console.ReadKey();
        }
    }
}
