/*Tehtävä 7
Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.

Esimerkkitoiminta:


    Numbers in an array 1: 10,20,30,40,50
    Numbers in an array 2: 5,15,25,35,45
    Numbers in the combined array: 5,10,15,20,25,30,35,40,45,50
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 20, 10, 50, 40, 30 };
            int[] array2 = { 15, 5, 35, 25, 45 };
            int[] array3 = new int[10];

            int temp;

            for (int i = 0; i < 5; i++)
            {
                array3[i] = array1[i];
            }

            for (int i = 0, e=5; i < 5; i++, e++ )
            {
                array3[e] = array2[i];
            }

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array3[i] > array3[j])
                    {
                        temp = array3[i];
                        array3[i] = array3[j];
                        array3[j] = temp;
                    }
                }
            }
            Console.Write("Numbers in array 1: ");
            foreach (int number in array1)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.Write("Numbers in array 2: ");
            foreach (int number in array2)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.Write("Numbers in combined array: ");
            foreach (int number in array3)
            {
                Console.Write(number+" ");
            }
            Console.ReadKey();
        }
    }
}
