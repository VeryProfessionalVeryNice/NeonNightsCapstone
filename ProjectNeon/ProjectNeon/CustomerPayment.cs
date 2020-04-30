using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNeon
{
    public partial class CustomerPayment : Form
    {
        

        public CustomerPayment(string selectedCustomerName, string outstandingBalance, string selectedInvoiceId)
        {
            InitializeComponent();
            txtBxName.Text = selectedCustomerName;
            decimal decOutstandingBalance = Convert.ToDecimal(outstandingBalance);
            txtBxBalance.Text = decOutstandingBalance.ToString("C", CultureInfo.CurrentCulture);
        }
        public CustomerPayment()
        {
            InitializeComponent();

        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            //txtBxName.Text = selectedCustomerName;
            //txtBxBalance.Text = string.Format("{0:C}", Form1.outstandingBalance);
            //Convert balance from string to decimal for display and calculation pruposes
            //decimal decOutstandingBalance = Convert.ToDecimal(Form1.outstandingBalance);
            //txtBxBalance.Text = decOutstandingBalance.ToString("C", CultureInfo.CurrentCulture);

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

        //only show check number txtBx when check option is selected
        private void cmbBxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxPayment.SelectedIndex == 1)
            {
                lblCheckNumber.Visible = true;
                txtBxCheckNum.Visible = true;
                
            }
            if (cmbBxPayment.SelectedIndex == 0)
            {
                lblCheckNumber.Visible = false;
                txtBxCheckNum.Visible = false;
            }
        }
    }
}
