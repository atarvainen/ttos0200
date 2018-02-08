using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class PaidWithCard : ITransaction
    {
        public float PaidAmount { get; set; }
        public float TotalSales { get; set; }

        public void CardTransaction(float number)
        {
            PaidAmount = number;
            TotalSales += number;
        }

        public string ShowTransaction()
        {
            String datenow = DateTime.Now.ToString("dd.MM.yyy");
            return "Transaction to bank: charge from card date: " + datenow + " amount: " + PaidAmount;
        }

        public float GetAmount()
        {
            return PaidAmount;
        }
    }
}
