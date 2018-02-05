using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }

        public List<Order> orders = new List<Order>();

        public void ShowOrders()
        {
            Console.WriteLine("Customer Id: {0} -{1} -{2}", CustomerId, Name, Address);
            foreach (Order order in orders)
            {
                Console.WriteLine("Order id: {0}", order.OrderId);
                order.ShowOrderItems();
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Customer Id: " + CustomerId + " Name: " + Name + " Address: " + Address;
        }
    }
}
