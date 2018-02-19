/*
Tehtävä 2 - Ostokset
Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. 
Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. 
Tulosta lopuksi kokoelman sisältö.

Esimerkkitulostus:


    All products in collection:
    - product : Milk 1,4 e
    - product : Beer 2,2 e
    - product : Butter 3,2 e
    - product : Cheese 4,2 e
    
    Press enter key to continue...
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
            List<Product> shoppingCart = new List<Product>
            {
                new Product{ Name = "maito", Price = 1.3f},
                new Product{ Name = "beer", Price = 2.2f},
                new Product{ Name = "butter", Price = 3.2f},
                new Product{ Name = "cheese", Price = 4.2f}
            };

            Console.WriteLine("All products in collection:");

            foreach (Product p in shoppingCart)
            {
                Console.WriteLine("-product : {0} {1} e", p.Name, p.Price);
            }
            Console.ReadKey();
        }
    }
}
