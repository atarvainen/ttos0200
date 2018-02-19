using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Fisher
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public List<Fish> fish = new List<Fish>();

        public void AddFish(string species, int width, float weight, string place, string location)
        {
            fish.Add(new Fish { Species = species, Width = width, Weight = weight, Place = place, Location = location });
        }

        public void ShowFishes()
        {
            Console.WriteLine("Fisherman {0} has got following fish:", this.Name);
            
            foreach (Fish f in fish)
            {
                Console.WriteLine("- specie: {0} {1}cm {2}kg", f.Species, f.Width, f.Weight);
                Console.WriteLine("- place: " + f.Place);
                Console.WriteLine("- location: " + f.Location);
            }
            Console.WriteLine();
        }

        public void ShowLargestFishes()
        {
            Console.WriteLine("All fish in register");
            
            foreach (Fish f in fish)
            {
                Console.WriteLine("- specie: {0} {1}cm {2}kg", f.Species, f.Width, f.Weight);
                Console.WriteLine("- place: " + f.Place);
                Console.WriteLine("- location: " + f.Location);
            }
            Console.WriteLine();
        }
    }
}
