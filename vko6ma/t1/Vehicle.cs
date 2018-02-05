using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Vehicle
    {
        private string Name { get; set; }
        private string Model { get; set; }

        private int tyreCounter { get; set; }

        private List<Tyre> tyres = new List<Tyre>();

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public override string ToString()
        {
            return "Vehicle name: " + Name + " Model: " + Model;
        }

        public void AddTyre(string model, string type, string tyresize)
        {
            tyres.Add(new Tyre(model, type, tyresize));
            Console.WriteLine("Tyre {0} added to vehicle {1}", tyres[tyreCounter].Model, Name);
            tyreCounter++;
        }

        public void PrintTyres()
        {
            Console.WriteLine("Tyres: ");
            foreach (Tyre tyre in tyres)
            {
                Console.WriteLine("-Name: {0} -Model: {1} -Tyresize: {2}", tyre.Model, tyre.Type, tyre.TyreSize);
            }
            Console.WriteLine();
        }
    }
}