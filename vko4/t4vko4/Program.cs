/*
 * Tehtävä 4
Luo Vehicle-luokka seuraavien tietojen mukaisesti:

ominaisuudet
Name:string
Speed:int
Tyres:int

toiminnot
PrintData(), tulostaa Vehiclen ominaisuudet näytölle
ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona

Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta. Muuta olion arvoja ja tulosta olion arvoja konsolille.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle toyota = new Vehicle();
            toyota.Name = "Corolla";
            toyota.Speed = 200;
            toyota.Tyres = 16;
            toyota.PrintData();
            Console.Write(toyota.ToString());
            Console.ReadKey();
        }
    }
}
