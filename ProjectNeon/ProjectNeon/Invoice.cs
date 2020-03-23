using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNeon
{
    class Invoice
    {
        private string id;
        private int customerId;
        private bool taxExempt;
        private decimal total;
        private DateTime dateIssued;
        private string paymentMethod;
        private string checkNum;

        public string Id { get => id; set => id = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public bool TaxExempt { get => taxExempt; set => taxExempt = value; }
        public decimal Total { get => total; set => total = value; }
        public DateTime DateIssued { get => dateIssued; set => dateIssued = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string CheckNum { get => checkNum; set => checkNum = value; }

        public Invoice() { }

        public Invoice(string id, int customerId, bool taxExempt, decimal total, DateTime dateIssued, string paymentMethod, string checkNum)
        {
            this.id = id;
            this.customerId = customerId;
            this.taxExempt = taxExempt;
            this.total = total;
            this.dateIssued = dateIssued;
            this.paymentMethod = paymentMethod;
            this.checkNum = checkNum;
        }

        public Invoice(string id, int customerId, bool taxExempt, decimal total, DateTime dateIssued, string paymentMethod)
        {
            this.id = id;
            this.customerId = customerId;
            this.taxExempt = taxExempt;
            this.total = total;
            this.dateIssued = dateIssued;
            this.paymentMethod = paymentMethod;
            checkNum = null;
        }
    }
}
