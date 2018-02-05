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
            Customer customer1 = new Customer {Name =  "Kalle Penttinen", Address = "Kuokkakuja 3", CustomerId = 12345 };
            Customer customer2 = new Customer { Name = "Matti Kukkonen", Address = "Piippukatu 3", CustomerId = 23456 };

            List<Order> orders = new List<Order>();

            orders.Add(new Order { OrderId = 1 });
            orders.Add(new Order { OrderId = 2 });
            orders.Add(new Order { OrderId = 3 });
            orders.Add(new Order { OrderId = 4 });

            List<OrderItem> orderitems = new List<OrderItem>();

            orderitems.Add(new OrderItem { ItemId = 0, ItemName = "Ruuvi" });
            orderitems.Add(new OrderItem { ItemId = 1, ItemName = "Mutteri" });
            orderitems.Add(new OrderItem { ItemId = 2, ItemName = "Pultti" });
            orderitems.Add(new OrderItem { ItemId = 3, ItemName = "Ruuvimeisseli" });
            orderitems.Add(new OrderItem { ItemId = 4, ItemName = "Porakone" });
            orderitems.Add(new OrderItem { ItemId = 5, ItemName = "Lapio" });
            orderitems.Add(new OrderItem { ItemId = 6, ItemName = "Maalipurkki" });
            orderitems.Add(new OrderItem { ItemId = 7, ItemName = "Sivellin" });

            orders[0].orderItems.Add(orderitems[0]);
            orders[0].orderItems.Add(orderitems[1]);
            orders[0].orderItems.Add(orderitems[2]);
            orders[1].orderItems.Add(orderitems[3]);
            orders[2].orderItems.Add(orderitems[4]);
            orders[2].orderItems.Add(orderitems[5]);
            orders[3].orderItems.Add(orderitems[6]);
            orders[3].orderItems.Add(orderitems[7]);

            customer1.orders.Add(orders[0]);
            customer1.orders.Add(orders[1]);
            customer2.orders.Add(orders[2]);
            customer2.orders.Add(orders[3]);

            customer1.ShowOrders();
            customer2.ShowOrders();

            Console.ReadKey();
        }
    }
}
