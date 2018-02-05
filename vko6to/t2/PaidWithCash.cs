using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class PaidWithCash : ITransaction
    {
        public float PaidAmount { get; set; }
        public float CashAmount { get; set; }
        public string ShowTransaction()
        {
           return "Paid with cash: Billnumber" + + " date: " + + " amount: " + );
        }

        public float GetAmount()
        {
            return value;
        }

        public float ShowCash()
        {
            return CashMoney += PaidAmount;
        }
    }
}
