using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectNeon
{
    class Invoice
    {
        private string InvoiceID;
        private int CustomerID;
        private bool TaxExempt;
        private float Total;
        private DateTime DateIssued;
        private string PaymentMethod;
        private string CheckNum;

        public string InvoiceID1 { get => InvoiceID; set => InvoiceID = value; }
        public int CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public bool TaxExempt1 { get => TaxExempt; set => TaxExempt = value; }
        public float Total1 { get => Total; set => Total = value; }
        public DateTime DateIssued1 { get => DateIssued; set => DateIssued = value; }
        public string PaymentMethod1 { get => PaymentMethod; set => PaymentMethod = value; }
        public string CheckNum1 { get => CheckNum; set => CheckNum = value; }
    }
}
