using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace ProjectNeon
{
    public partial class AlterInvoice : Form
    {
        //Make item array to fill listbox
        Item[] newItems = new Item[30];
        int index;
        string cntString;
        Invoice newInvoice = new Invoice();
        decimal taxRate;
        public AlterInvoice(string conn, Item[] items, Invoice invoice, decimal tax)
        {
            cntString = conn;
            newItems = items;
            newInvoice = invoice;
            taxRate = tax;
            //MessageBox.Show(newInvoice.Id);
            InitializeComponent();
            //Fill fields with information
            txtBxId.Text = newInvoice.Id;
            ckBxTaxExempt.Checked = newInvoice.TaxExempt;
            dateIssued.Value = newInvoice.DateIssued;
            cmbBxPayment.Text = newInvoice.PaymentMethod;
            txtBxCheckNum.Text = newInvoice.CheckNum;
            foreach(Item item in items)
            {
                if (item != null)
                    lstBxItems.Items.Add(item);
            }
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Deletes selected item
            int index = lstBxItems.SelectedIndex;
            lstBxItems.Items.RemoveAt(index);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //validates item fields
            if (ValidateItem())
            {
                Item newItem = new Item
                {
                    ItemCode = txtBxItemCode.Text,
                    Quantity = Convert.ToByte(nudQty.Value),
                    Description = txtBxDesc.Text,
                    PriceEach = Convert.ToDecimal(txtBxPriceEach.Text)
                };

                lstBxItems.Items.Add(newItem);
                //Empties item input fields
                ResetItemFields();
            }
        }

        private bool ValidateItem()
        {
            //checks all required item fields to check for validity
            if (txtBxItemCode.Text != "" && nudQty.Value > 0 && txtBxPriceEach.Text != "")
            {
                try
                {
                    decimal priceEach = Convert.ToDecimal(txtBxPriceEach.Text);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ResetItemFields()
        {
            //Reset Item Fields
            txtBxItemCode.Text = "";
            nudQty.Value = 1;
            txtBxPriceEach.Text = "";
            txtBxDesc.Text = "";
        }

        private void lstBxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstBxItems.SelectedIndex;
            try
            {
                //Add
                Item item = lstBxItems.SelectedItem as Item;
                txtBxItemCode.Text = item.ItemCode.ToString();
                nudQty.Value = item.Quantity;
                txtBxPriceEach.Text = item.PriceEach.ToString();
                txtBxDesc.Text = item.Description;
            }
            catch 
            {
                lstBxItems.SelectedIndex = -1;
            }
        }

        private void btnAlterItem_Click(object sender, EventArgs e)
        {
            Item emptyItem = new Item();
            newItems[index] = emptyItem;
            btnAddItem_Click(sender, e);
            lstBxItems.Items.RemoveAt(index);
            lstBxItems.SelectedIndex = -1;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool exempt = GetTaxStatus();
            decimal total = GetTotal();
            //query to update invoice information
            string sql = $"UPDATE Invoice SET TaxExempt = '{exempt}', Total = '{total}', DateIssued = '{dateIssued.Value.ToShortDateString()}', PaymentMethod = '{cmbBxPayment.Text}', CheckNum = '{txtBxCheckNum.Text}' WHERE InvoiceID = {newInvoice.Id}";
            string sql2 = $"UPDATE Customer SET Balance = '{total}' WHERE CustomerID = '{newInvoice.CustomerId}'";
            SqlConnection conn = new SqlConnection(cntString);
            Connect(conn);
            try
            {
                //Update invoice
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                foreach (Item item in lstBxItems.Items)
                {
                    string query = $"UPDATE Item SET ItemCode = '{item.ItemCode}', Quantity = '{item.Quantity}', Description = '{item.Description}', PriceEach = '{item.PriceEach}' WHERE ItemID = {item.Id}";
                    try
                    {
                        //Add customer to database
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch { }
                }
                using (SqlCommand command = new SqlCommand(sql2, conn))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
            catch { }
            finally
            {
                Disconnect(conn);
                //Close Form
                this.Close();
            }
        }

        private decimal GetTotal()
        {
            decimal total = 0m;
            foreach (Item item in lstBxItems.Items)
            {
                total += (item.PriceEach * item.Quantity);
            }

            total += GetTax(total);

            return total;
        }

        private decimal GetTax(decimal total)
        {
            if (ckBxTaxExempt.Checked)
            {
                return 0m;
            }
            else
            {
                return total * taxRate;
            }
        }

        private bool GetTaxStatus()
        {
            if (ckBxTaxExempt.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
