/*
Tehtävä 1
Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. 
Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) 
ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon 
renkaat Rengas-olioina esim. taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat 
käsitellään tarkemmin seuraavissa demoissa). Tee pääohjelma, jossa luot muutamia kulkuneuvoja 
(esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa 
niitä suoraan pääohjelman koodissa.

Esimerkkitoiminta:

    Created a new vehichle Porsche model 911
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    
    Vechicle Name: Porsche Model:911
    Tyres:
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    
    Created a new vehichle Ducati model Diavel
    Tyre MIC added to vehicle Ducati
    Tyre MIC added to vehicle Ducati
    
    Vechicle Name: Ducati Model:Diavel
    Tyres:
    -Name: MIC Model:Pilot TyreSize:160R17
    -Name: MIC Model:Pilot TyreSize:140R16    
    ...
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
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Vehicle("Porsche", "911"));
            
            vehicles[0].AddTyre("Nokia", "Hakkapeliitta", "205R16");
            vehicles[0].AddTyre("Nokia", "Hakkapeliitta", "205R16");
            vehicles[0].AddTyre("Nokia", "Hakkapeliitta", "205R16");
            vehicles[0].AddTyre("Nokia", "Hakkapeliitta", "205R16");
            Console.WriteLine();

            Console.WriteLine(vehicles[0].ToString());
            vehicles[0].PrintTyres();

            vehicles.Add(new Vehicle("Ducati", "Diavel"));

            vehicles[1].AddTyre("MIC", "Pilot", "160R17");
            vehicles[1].AddTyre("MIC", "Pilot", "140R16");
            Console.WriteLine();

            Console.WriteLine(vehicles[1].ToString());
            vehicles[1].PrintTyres();
        }
    }
}
