using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Refrigerator
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Ingredient> ingredients = new List<Ingredient>();

        public Refrigerator(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void AddIngredient(string name, DateTime bestbefore)
        {
            ingredients.Add(new Ingredient(name, bestbefore));
        }

        public void PrintIngredients()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine("Nimi: {0}, Parasta ennen: ", ingredient.Name, ingredient.BestBefore);
            }
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public DateTime BestBefore { get; set; }

        public Ingredient(string name, DateTime bestbefore)
        {
            Name = name;
            BestBefore = bestbefore;
        }
    }
}
