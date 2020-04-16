using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProjectNeon
{
    public partial class InvoiceForm : Form
    {
        //private PrintDocument printDocument1 = new PrintDocument();
        public InvoiceForm()
        {
            InitializeComponent();
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
        }

        Bitmap memoryImage;

        void printButton_Click(object sender, EventArgs e)
        {
            //CaptureScreen();
            //PrintDialog print = new PrintDialog();
            //printDocument1.DocumentName = "Test Doc";
            //print.Document = printDocument1;
            //print.AllowSelection = true;
            //print.AllowSomePages = true;
            //if (print.ShowDialog() == DialogResult.OK)
            //        printDocument1.Print();
            memoryImage = new Bitmap(InvoicePanel.Width, InvoicePanel.Height);
            InvoicePanel.DrawToBitmap(memoryImage, new Rectangle(0, 0, InvoicePanel.Width, InvoicePanel.Height));
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //    printDocument2.Print();
            printPreviewDialog1.ShowDialog();
        }

        

        private void CaptureScreen()
        {
            //Graphics myGraphics = InvoicePanel.CreateGraphics();
            //Size s = this.InvoicePanel.Size;
            //memoryImage = new Bitmap(this.InvoicePanel.Width, this.InvoicePanel.Height, myGraphics);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //memoryGraphics.CopyFromScreen(this.InvoicePanel.Location.X, this.InvoicePanel.Location.Y, 0, 0, s);
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
