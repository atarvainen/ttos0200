using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class OrderItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public override string ToString()
        {
            return "Item ID: " + ItemId + " Item name: " + ItemName;
        }
    }
}
