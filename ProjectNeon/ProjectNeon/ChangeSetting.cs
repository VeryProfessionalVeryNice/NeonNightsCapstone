using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjectNeon
{
    public partial class ChangeSetting : Form
    {
        public ChangeSetting(decimal tax)
        {
            InitializeComponent();
            txtBxTaxRate.Text = (tax * 100).ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal newTax = Convert.ToDecimal(txtBxTaxRate.Text);
            newTax /= 100;
            XmlDocument doc = new XmlDocument();
            doc.Load("TaxRate.xml");
            doc.LastChild.FirstChild.InnerText = newTax.ToString();
            doc.Save("TaxRate.xml");
            this.Close();
        }
    }
}
