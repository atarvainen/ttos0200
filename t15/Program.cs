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
                Console.Write("Give a number: ");
                int input = int.Parse(Console.ReadLine());
                for (int i = 0; i < input; i++)
                {
                    for (int e = input-1; e > i; e--)
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
                for (int i=0; i < 2 ;i++)
                {
                    for (int j=0; j < input -1 ;j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                Console.WriteLine();
                Console.ReadLine();
        }
    }
}
