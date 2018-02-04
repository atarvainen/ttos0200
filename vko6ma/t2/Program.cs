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
            List<Ingredient> ingredients = new List<Ingredient>();
            Refrigerator fridge = new Refrigerator("Helkama", "1234");

            ingredients.Add(new Ingredient("Margariini", new DateTime(2018, 3, 3)));
            ingredients.Add(new Ingredient("Kananmuna", new DateTime(2018, 2, 12)));
            ingredients.Add(new Ingredient("Maitopurkki", new DateTime(2018, 2, 6)));
            ingredients.Add(new Ingredient("Ketsuppi", new DateTime(2018, 5, 10)));
            ingredients.Add(new Ingredient("Suolakurkku", new DateTime(2019, 7, 20)));
            ingredients.Add(new Ingredient("Pinaattikeitto", new DateTime(2018, 2, 12)));
            ingredients.Add(new Ingredient("Raejuusto", new DateTime(2018, 2, 25)));
            
            foreach (Ingredient ingredient in ingredients)
            {
                fridge.ingredientsInFridge.Add(ingredient);
            }

            Console.WriteLine(fridge.ToString());
            fridge.GetIngredientsInFridge();
            Console.ReadKey();
        }
    }
}
