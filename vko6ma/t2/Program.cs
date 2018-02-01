/*
Tehtävä 2
Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy.Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            ingredients.Add(new Ingredient("Margariini", new DateTime(12, 03, 2018)));
            ingredients.Add(new Ingredient("Kananmuna", new DateTime(10, 02, 2018)));
            ingredients.Add(new Ingredient("Maitopurkki", new DateTime(05, 02, 2018)));
            ingredients.Add(new Ingredient("Ketsuppi", new DateTime(20, 05, 2018)));
            ingredients.Add(new Ingredient("Suolakurkku", new DateTime(30, 07, 2019)));
            ingredients.Add(new Ingredient("Pinaattikeitto", new DateTime(33, 02, 2018)));
            ingredients.Add(new Ingredient("Raejuusto", new DateTime(20, 02, 2018)));
        }
    }
}
