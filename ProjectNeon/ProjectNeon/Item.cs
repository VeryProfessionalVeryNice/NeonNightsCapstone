using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNeon
{
    class Item
    {
        private int id;
        private string invoiceId;
        private string itemCode;
        private byte quantity;
        private string description;
        private decimal priceEach;

        public int Id { get => id; set => id = value; }
        public string InvoiceId { get => invoiceId; set => invoiceId = value; }
        public string ItemCode { get => itemCode; set => itemCode = value; }
        public byte Quantity { get => quantity; set => quantity = value; }
        public string Description { get => description; set => description = value; }
        public decimal PriceEach { get => priceEach; set => priceEach = value; }

        public Item() { }

        public Item(string invoiceId, string itemCode, byte quantity, string description, decimal priceEach)
        {
            id = 0;
            this.invoiceId = invoiceId;
            this.itemCode = itemCode;
            this.quantity = quantity;
            this.description = description;
            this.priceEach = priceEach;
        }
        public Item(int id, string invoiceId, string itemCode, byte quantity, string description, decimal priceEach)
        {
            this.id = id;
            this.invoiceId = invoiceId;
            this.itemCode = itemCode;
            this.quantity = quantity;
            this.description = description;
            this.priceEach = priceEach;
        }
    }
}
