using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Order
    {
        public int OrderId { get; set; }

        public List<OrderItem> orderItems = new List<OrderItem>();

        public void ShowOrderItems()
        {
            foreach (OrderItem item in orderItems)
            {
                Console.WriteLine("Item id: {0} Item name: {1}", item.ItemId, item.ItemName);
            }
        }
    }
}
