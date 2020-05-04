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
using System.Data.SqlClient;

namespace ProjectNeon
{
    public partial class CustomerPayment : Form
    {
        string cntString;
        string id;
        int custID;
        decimal decOutstandingBalance;
        public CustomerPayment(string selectedCustomerName, string outstandingBalance, string selectedInvoiceId, string conn1, int customerID)
        {
            InitializeComponent();
            //Set connection string
            cntString = conn1;
            id = selectedInvoiceId;
            custID = customerID;
            txtBxName.Text = selectedCustomerName;
            decOutstandingBalance = Convert.ToDecimal(outstandingBalance);
            txtBxBalance.Text = decOutstandingBalance.ToString("C", CultureInfo.CurrentCulture);
        }
        public CustomerPayment()
        {
            InitializeComponent();

        }

        #region Database Connections
        private void Connect(SqlConnection conn)
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Disconnect(SqlConnection conn)
        {
            try
            {
                conn.Close();//Close Connection
                //MessageBox.Show("Closed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

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

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            //Apply payment to database and create messagebox telling user payment has been applied
            //MessageBox.Show()
            decimal balance = decOutstandingBalance - Convert.ToDecimal(txtBxPaymentAmount.Text);
            //MessageBox.Show(balance.ToString());
            string invoiceSql = $"UPDATE Invoice SET DateIssued = '{paymentDate.Value.ToShortDateString()}', PaymentMethod = '{cmbBxPayment.Text}', CheckNum = '{txtBxCheckNum.Text}' WHERE InvoiceID = '{id}'";
            string customerSql = $"UPDATE Customer SET Balance = '{balance}' WHERE CustomerID = '{custID}'";
            SqlConnection conn = new SqlConnection(cntString);
            Connect(conn);
            try
            {
                using (SqlCommand command = new SqlCommand(invoiceSql, conn))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand(customerSql, conn))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Payment successfully recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect(conn);
                this.Close();
            }
        }
    }
}
