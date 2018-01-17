/*Tehtävä 5
Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.


    Give a number: 7 [Enter]    
        *
       ***
      *****
     *******
    *********
        *
        *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t15
{
    class Program
    {
        static void Main(string[] args)
        {
                //Console.Write("Give a number: ");
                //int input = int.Parse(Console.ReadLine());
                //int first = input - 2;
                for (int i = 0; i < 5; i++)
                {
                    for (int e = 4; e > i; e--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                                        for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i= 0; i < 2;i++)
                {
                    for (int e = 1; e >= i; e--)
                    {
                        Console.Write("2");
                    }
                }
                Console.WriteLine();
                Console.ReadLine();
        }
    }
}
