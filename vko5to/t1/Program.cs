/*
Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). Työntekijöiden osalta 
seuraavia tietoa pitää pystyä käsittelemään: työntekijän nimi (Name), työntekijän ammatti 
(Profession) ja palkka (Salary). Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien 
tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. Toteuta tämän 
jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. Tulosta vaadittujen luokkien 
olioiden tietoja output-ikkunaan. Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan 
voit alustaa ne suoraan pääohjelmassa.

Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)


    Employee:
    - Name:Kirsi Kernel Profession:Teacher Salary:1200
    
    Boss:
    - Name:Jussi Jurkka Profession:Head of Institute Salary:9000 Car:Audi Bonus:5000
    
    Employee:
    - Name:Kirsi Kernel Profession:Principal Teacher Salary:2200
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kernel", "Teacher", 1200);
            Employee jussi = new Boss("Jussi Jurkka", "Head of Institute", 9000, "Audi", 5000);
            jussi.Name = "Jussi";

            Console.WriteLine(kirsi.ToString());
            Console.WriteLine(jussi.ToString());

            Console.ReadKey();
        }
    }
}
