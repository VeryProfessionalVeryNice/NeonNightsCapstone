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
            Panel[] panels = new Panel[] {panel2, panel1, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12, panel13, panel14, panel15, panel16, panel17, panel18 };
            foreach (Panel panel in panels)
            {
                panel.Parent = InvoicePanel;
            }
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

            Print();
            //printPreviewDialog1.ShowDialog();
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
                e.Graphics.DrawImage(memoryImage, 0, 0);
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
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (InvoicePanel.Width / 2), InvoicePanel.Location.Y);
        }
    }
}
