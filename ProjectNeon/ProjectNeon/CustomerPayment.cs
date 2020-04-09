using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNeon
{
    public partial class CustomerPayment : Form
    {
        public CustomerPayment()
        {
            InitializeComponent();
        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            txtBxName.Text = Form1.selectedCustomerName;
            txtBxBalance.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", Form1.outstandingBalance);
            
        }
        
        private void txtBxPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        //only allows numbers and decimal points as input, might let through pasted text, still need to add further validation when clicking add payment button
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtBxPaymentAmount.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
