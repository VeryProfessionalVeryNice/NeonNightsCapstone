using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProjectNeon
{
    public partial class InvoiceForm : Form
    {
        private Label[] quantityAry;
        private Label[] itemCodeAry;
        private Label[] descAry;
        private Label[] priceAry;
        private Label[] amountAry;
        private Label[] salesTaxAry;
        private Label[] percentAry;
        private Label[] taxAmtAry;
        private decimal taxRate = 0.081m;
        private bool isPaid = false;
        public InvoiceForm(Customer cust, Invoice invoice, Item[] items)
        {
            InitializeComponent();
            //Assigns labels to arrays for filling with information or hiding
            quantityAry = CreateQtyArray();
            itemCodeAry = CreateCodeArray();
            descAry = CreateDescArray();
            priceAry = CreatePriceArray();
            amountAry = CreateAmountArray();
            salesTaxAry = CreateSalesTaxArray();
            percentAry = CreatePercentArray();
            taxAmtAry = CreateTaxAmountArray();
            //Fill lables with information
            lblDate.Text = invoice.DateIssued.ToShortDateString();
            lblInvoiceNum.Text = $"#{invoice.Id}";
            //lblName.Text = $"Bill To: {cust.CompanyName}";
            lblAddress.Text = $"{cust.CompanyName}\r\n{cust.AddressLine1} {cust.AddressLine2}\r\n{cust.City}, {cust.State} {cust.Zip}";
            lblTotal.Text = invoice.Total.ToString("F2");
            for (int i = 0; i < 15; i++)
            {
                if (items[i] != null)
                {
                    quantityAry[i].Text = items[i].Quantity.ToString();
                    itemCodeAry[i].Text = items[i].ItemCode;
                    descAry[i].Text = items[i].Description;
                    priceAry[i].Text = items[i].PriceEach.ToString("F2");
                    amountAry[i].Text = GetItemAmount(items[i].Quantity, items[i].PriceEach);
                    if (!invoice.TaxExempt)
                    {
                        taxAmtAry[i].Text = GetTaxAmount(Convert.ToDecimal(amountAry[i].Text));
                    }
                    else
                    {
                        taxAmtAry[i].Visible = false;
                        percentAry[i].Visible = false;
                        salesTaxAry[i].Visible = false;
                    }
                } 
                else
                {
                    quantityAry[i].Visible = false;
                    itemCodeAry[i].Visible = false;
                    descAry[i].Visible = false;
                    priceAry[i].Visible = false;
                    amountAry[i].Visible = false;
                    taxAmtAry[i].Visible = false;
                    taxAmtAry[i].Visible = false;
                    percentAry[i].Visible = false;
                    salesTaxAry[i].Visible = false;
                }
            }
            IsVisable();
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
            //Set panels parents so that they show up in the pdf
            Panel[] panels = new Panel[] {panel2, panel1, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12, panel13, panel14, panel15, panel16, panel17, panel18 };
            foreach (Panel panel in panels)
            {
                panel.Parent = InvoicePanel;
            }
        }

        Bitmap memoryImage;

        void printButton_Click(object sender, EventArgs e)
        {
            Print();
        }

        public void GetPrintArea()
        {
            memoryImage = new Bitmap(InvoicePanel.Width, InvoicePanel.Height);
            InvoicePanel.DrawToBitmap(memoryImage, new Rectangle(0, 0, InvoicePanel.Width, InvoicePanel.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (memoryImage != null)
            {
                e.Graphics.DrawImage(memoryImage, 10, 10);
                base.OnPaint(e);
            }
        }

        public void Print()
        {
            GetPrintArea();
            printDialog1.Document = printDocument2;
            printDialog1.AllowCurrentPage = true;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            printDialog1.PrintToFile = true;
            //printDialog1.ShowDialog();
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (InvoicePanel.Width / 2), InvoicePanel.Location.Y);
        }

        private Label[] CreateQtyArray()
        {
            Label[] labels = new Label[] {lblQty1, lblQty2, lblQty3, lblQty4, lblQty5, lblQty6, lblQty7, lblQty8, lblQty9, lblQty10,
            lblQty11, lblQty12, lblQty13, lblQty14, lblQty15};
            return labels;
        }

        private Label[] CreateCodeArray()
        {
            Label[] labels = new Label[] {lblCode1, lblCode2, lblCode3, lblCode4, lblCode5, lblCode6, lblCode7, lblCode8, lblCode9, lblCode10,
            lblCode11, lblCode12, lblCode13, lblCode14, lblCode15};
            return labels;
        }

        private Label[] CreateDescArray()
        {
            Label[] labels = new Label[] {lblDesc1, lblDesc2, lblDesc3, lblDesc4, lblDesc5, lblDesc6, lblDesc7, lblDesc8, lblDesc9, lblDesc10,
            lblDesc11, lblDesc12, lblDesc13, lblDesc14, lblDesc15};
            return labels;
        }

        private Label[] CreatePriceArray()
        {
            Label[] labels = new Label[] {lblPrice1, lblPrice2, lblPrice3, lblPrice4, lblPrice5, lblPrice6, lblPrice7, lblPrice8, lblPrice9, lblPrice10,
            lblPrice11, lblPrice12, lblPrice13, lblPrice14, lblPrice15};
            return labels;
        }

        private Label[] CreateAmountArray()
        {
            Label[] labels = new Label[] {lblAmt1, lblAmt2, lblAmt3, lblAmt4, lblAmt5, lblAmt6, lblAmt7, lblAmt8, lblAmt9, lblAmt10,
            lblAmt11, lblAmt12, lblAmt13, lblAmt14, lblAmt15};
            return labels;
        }

        private Label[] CreateSalesTaxArray()
        {
            Label[] labels = new Label[] {lblTax1, lblTax2, lblTax3, lblTax4, lblTax5, lblTax6, lblTax7, lblTax8, lblTax9, lblTax10,
            lblTax11, lblTax12, lblTax13, lblTax14, lblTax15};
            return labels;
        }

        private Label[] CreatePercentArray()
        {
            Label[] labels = new Label[] {lblPer1, lblPer2, lblPer3, lblPer4, lblPer5, lblPer6, lblPer7, lblPer8, lblPer9, lblPer10,
            lblPer11, lblPer12, lblPer13, lblPer14, lblPer15};
            return labels;
        }

        private Label[] CreateTaxAmountArray()
        {
            Label[] labels = new Label[] {lblTaxAmt1, lblTaxAmt2, lblTaxAmt3, lblTaxAmt4, lblTaxAmt5, lblTaxAmt6, lblTaxAmt7, lblTaxAmt8,
            lblTaxAmt9, lblTaxAmt10, lblTaxAmt11, lblTaxAmt12, lblTaxAmt13, lblTaxAmt14, lblTaxAmt15};
            return labels;
        }

        private string GetItemAmount(int qty, decimal price)
        {
            //decimal quant = Convert.ToDecimal(qty);
            decimal result = qty * price;
            return result.ToString("F2");
        }

        private string GetTaxAmount(decimal total)
        {
            decimal tax = total * taxRate;
            return (total + tax).ToString("F2");
        }

        private void chBxPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxPaid.Checked)
                isPaid = true;
            else
                isPaid = false;
            IsVisable();
        }
        
        private void IsVisable()
        {
            if (isPaid)
                lblPaid.Visible = true;
            else
                lblPaid.Visible = false;
        }

        private void lblPaid_Click(object sender, EventArgs e)
        {

        }
    }
}
