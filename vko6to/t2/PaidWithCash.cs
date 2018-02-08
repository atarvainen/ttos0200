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
        public float TotalSales { get; set; }
        public int Billnumber = 0;

        public void CashTransaction(float number)
        {
            PaidAmount = number;
            TotalSales += number;
        }

        public string ShowTransaction()
        {
            String datenow = DateTime.Now.ToString("dd.MM.yyy");
            return "Paid with cash: billnumber " + ++Billnumber + " date: " + datenow + " amount: " + PaidAmount;
        }

        public float GetAmount()
        {
            return PaidAmount;
        }

        public float ShowCash()
        {
            return TotalSales;
        }
    }
}
