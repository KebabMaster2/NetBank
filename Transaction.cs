using System;
using System.Collections.Generic;
using System.Text;

namespace iBankaBaltija
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }
        private List<Transaction> transactions = new List<Transaction>();
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }


    }
}
