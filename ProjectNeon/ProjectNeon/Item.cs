using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNeon
{
    class Item
    {
        private int ItemID;
        private string InvoiceID;
        private string ItemCode;
        private int Quantity;
        private string Description;
        private float PriceEach;

        public int ItemID1 { get => ItemID; set => ItemID = value; }
        public string InvoiceID1 { get => InvoiceID; set => InvoiceID = value; }
        public string ItemCode1 { get => ItemCode; set => ItemCode = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public string Description1 { get => Description; set => Description = value; }
        public float PriceEach1 { get => PriceEach; set => PriceEach = value; }
    }
}
