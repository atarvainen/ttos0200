/*
Tehtävä 1
Tee oheisen kuvan mukaiset luokat ja niiden välille tarvittavat koosteet. Eli yhdelle asiakkaalla (Customer) voi olla yksi tai useampi tilaus (Order) ja yhdessä tilauksessa voi olla yksi tai useampi tilaustuote (OrderItem). Mieti ja suunnittele mitä ominaisuuksia ja mitä metodeja kukin luokka tarvii. Toteuta esimerkiksi luokalle Customer metodi ShowOrders() joka näyttää asiakkaan kaikki tilaukset.
Tee testausta varten luokka ja sille sopiva metodi, joka luo muutaman asiakkaan ja heille tilauksia tilausriveineen.
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
            Test test = new Test();

            test.AddCustomer("Kalle Penttinen", "Kuokkakuja 3", 12345);
            test.AddCustomer("Matti Kukkonen", "Piippukatu 3", 23456);

            test.AddOrder(1);
            test.AddOrder(2);
            test.AddOrder(3);
            test.AddOrder(4);

            test.AddOrderItem(0, "Ruuvi");
            test.AddOrderItem(1, "Mutteri" );
            test.AddOrderItem(2, "Pultti" );
            test.AddOrderItem(3, "Ruuvimeisseli" );
            test.AddOrderItem(4, "Porakone" );
            test.AddOrderItem(5, "Lapio" );
            test.AddOrderItem(6, "Maalipurkki" );
            test.AddOrderItem(7, "Sivellin" );

            test.AddItemToOrder(0, 0);
            test.AddItemToOrder(0, 1);
            test.AddItemToOrder(0, 2);
            test.AddItemToOrder(1, 3);
            test.AddItemToOrder(2, 4);
            test.AddItemToOrder(2, 5);
            test.AddItemToOrder(3, 6);
            test.AddItemToOrder(3, 7);

            test.AddOrderToCustomer(0, 0);
            test.AddOrderToCustomer(0, 1);
            test.AddOrderToCustomer(1, 2);
            test.AddOrderToCustomer(1, 3);

            test.customers[0].ShowOrders();
            test.customers[1].ShowOrders();

            Console.ReadKey();
        }
    }
}
