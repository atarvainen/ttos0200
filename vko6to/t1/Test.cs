using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Test
    {
        public List<OrderItem> orderitems = new List<OrderItem>();
        public List<Order> orders = new List<Order>();
        public List<Customer> customers = new List<Customer>();

        public void AddCustomer(string name, string address, int customerId)
        {
            customers.Add(new Customer(name, address, customerId));
        }

        public void AddOrder(int orderId)
        {
            orders.Add(new Order(orderId));
        }

        public void AddOrderItem(int itemId, string itemName)
        {
            orderitems.Add(new OrderItem(itemId, itemName));
        }

        public void AddOrderToCustomer(int customerid, int orderid)
        {
            customers[customerid].orders.Add(orders[orderid]);
        }

        public void AddItemToOrder(int itemid, int orderid)
        {
            orders[itemid].orderItems.Add(orderitems[orderid]);
        }
    }
}
