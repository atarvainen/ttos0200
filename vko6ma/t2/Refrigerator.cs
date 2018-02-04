using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Refrigerator
    {
        public List<Ingredient> ingredientsInFridge = new List<Ingredient>();
        public string Name { get; set; }
        public string Model { get; set; }

        public Refrigerator(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void GetIngredientsInFridge()
        {
            foreach (Ingredient ingredient in ingredientsInFridge)
            {
                DateTime dateOnly = ingredient.BestBefore;
                Console.WriteLine("Ingredient: {0} Best Before: {1}", ingredient.Name, dateOnly.ToString("d"));
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model;
        }
    }
}
