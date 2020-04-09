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
    public partial class Form1 : Form
    {
        
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True

        private static string cntStrng = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                               @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
                              "Integrated Security=True;";

        //Item[] itemAry = new Item[500];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet1.Customer);
            FillCustomersTab();
            
            //LoadTestData(); //autoloading test data for now
        }

        private void safePDF_Click(object sender, EventArgs e)
        {
            try
            { 
                string path = Directory.GetCurrentDirectory();
                string target = @"";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }
        }

        #region Database
        #region Database Connections
        private void Connect(SqlConnection conn)
        {
            try
            {
                conn.Open();
                lblStatus.Text = "Connected to database successfully";
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closes database connection when the form is closed
          // Disconnect();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cntStrng);
            string sql = "SELECT * FROM Customer";
            string[] data = new string[8];
            SqlCommand command = new SqlCommand(sql, conn);
            //textBox1.Text = "";


            try
            {
                Connect(conn);
                SqlDataReader reader = command.ExecuteReader(); //Opens SqlReader
            while (reader.Read())
                {
                    for (int i = 0; i < 8; i++)
                    {
                        data[i] = reader[i].ToString();
                    }

                    Customer newCust = new Customer
                    {
                        Id = Convert.ToInt32(data[0]),
                        CompanyName = data[1].ToString(),
                        JobType = data[2].ToString(),
                        AddressLine1 = data[3].ToString(),
                        AddressLine2 = data[4].ToString(),
                        City = data[5].ToString(),
                        State = data[6].ToString(),
                        Zip = data[7].ToString()
                    };

                    //textBox1.Text += newCust.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect(conn);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
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
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
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

        private void ResetAllFields()
        {
            txtBxName.Text = "";
            txtBxAddress1.Text = "";
            txtBxAddress2.Text = "";
            txtBxCity.Text = "";
            txtBxState.Text = "";
            txtBxZip.Text = "";
            cmbBxJobType.SelectedIndex = 0;
            txtBxInvoiceId.Text = "";
            ckBxTaxExempt.Checked = false;
            dateIssued.Value = DateTime.Now;
            cmbBxPayment.SelectedIndex = 0;
            txtBxCheckNum.Text = "";
            lstBxItems.Items.Clear();
            ResetItemFields();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Deletes selected item
            int index = lstBxItems.SelectedIndex;
            lstBxItems.Items.RemoveAt(index);
            lblStatus.Text = "Deleted Item";
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            if (ValidateCustomer() && ValidateInvoice())
            {
                int custId = AddCustomer();
                AddInvoice(custId);
                AddItems();
            }
            ResetAllFields();
            FillCustomersTab();
            lblStatus.Text = "Added Invoice";
        }

        private int AddCustomer()
        {
            //Int to hold customer Id to tie invoice to customer
            int id = 0;

            SqlConnection conn = new SqlConnection(cntStrng);
            string query = $"INSERT INTO Customer(CompanyName, JobType, AddressLine1, AddressLine2, City, State, Zip)" +
                $"VALUES ('{txtBxName.Text}', '{cmbBxJobType.Text}', '{txtBxAddress1.Text}', '{txtBxAddress2.Text}', '{txtBxCity.Text}', '{txtBxState.Text}', '{txtBxZip.Text}');";
            string idQuery = $"SELECT CustomerID FROM Customer WHERE CompanyName = '{txtBxName.Text}'";
            try
            {
                //Add customer to database
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandType = CommandType.Text;
                    Connect(conn);
                    command.ExecuteNonQuery();
                    Disconnect(conn);
                }
                //Gets identity Id from added customer
                using (SqlCommand command = new SqlCommand(idQuery, conn))
                {
                    command.CommandType = CommandType.Text;
                    Connect(conn);
                    id = Convert.ToInt32(command.ExecuteScalar());
                    //MessageBox.Show(id.ToString());
                    Disconnect(conn);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message + " Customer insert error";
            }
            return id;
        }

        private bool ValidateCustomer()
        {
            bool isValid = true;
            //Array of customer fields
            TextBox[] textBoxes = new TextBox[5]
            {
                txtBxName,
                txtBxAddress1,
                txtBxCity,
                txtBxState,
                txtBxZip
            };
            //Loops through customer fields to check if any are empty
            foreach(TextBox txtBx in textBoxes)
            {
                if (txtBx.Text == "")
                {
                    //if field is empty set isValid to false
                    isValid = false;
                }
            }

            return isValid;
        }

        private void AddItems()
        {
            SqlConnection conn = new SqlConnection(cntStrng);
            Connect(conn);

            foreach (Item item in lstBxItems.Items)
            {
                string query = $"INSERT INTO Item(InvoiceID, ItemCode, Quantity, Description, PriceEach)" +
                $"VALUES ('{txtBxInvoiceId.Text}', '{item.ItemCode}', '{item.Quantity}', '{item.Description}', '{item.PriceEach}');";
                try
                {
                    //Add customer to database
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message + " Item insert error";
                }
                finally
                {

                    lblStatus.Text = "Added Invoice";
                }
            }
            Disconnect(conn);
        }

        private void AddInvoice(int custId)
        {
            bool exempt = GetTaxStatus();
            decimal total = GetTotal();

            SqlConnection conn = new SqlConnection(cntStrng);
            string query = $"INSERT INTO Invoice(InvoiceID, CustomerID, TaxExempt, Total, DateIssued, PaymentMethod, CheckNum)" +
                $"VALUES ('{txtBxInvoiceId.Text}', '{custId}', '{exempt}', '{total}', '{dateIssued.Value.ToShortDateString()}', '{cmbBxPayment.Text}', '{txtBxCheckNum.Text}');";
            try
            {
                //Add customer to database
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandType = CommandType.Text;
                    Connect(conn);
                    command.ExecuteNonQuery();
                    Disconnect(conn);
                }
                UpdateBalance(custId);
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message + " Invoice insert error";
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

        private decimal GetTotal()
        {
            decimal total = 0m;
            foreach (Item item in lstBxItems.Items)
            {
                total += (item.PriceEach * item.Quantity);
            }

            total = total + GetTax(total);

            return total;
        }

        private decimal GetTax(decimal total)
        {
            if (ckBxTaxExempt.Checked)
            {
                return total;
            }
            else
            {
                return total * 0.081m;
            }
        }

        private bool ValidateInvoice()
        {
            bool isValid = true;

            if (txtBxInvoiceId.Text == "")
                isValid = false;

            if (cmbBxPayment.Text == "Check")
            {
                if (txtBxCheckNum.Text == "")
                    isValid = false;
            }

            return isValid;
        }

        private void UpdateBalance(int id)
        {
            decimal total = 0m;
            SqlConnection conn = new SqlConnection(cntStrng);
            string sumQuery = $"SELECT SUM(Total) FROM Invoice WHERE CustomerID = '{id}'";
            
            try
            {
                using (SqlCommand command = new SqlCommand(sumQuery, conn))
                {
                    command.CommandType = CommandType.Text;
                    Connect(conn);
                    total = Convert.ToDecimal(command.ExecuteScalar());
                    //MessageBox.Show(total.ToString("C2"));
                    Disconnect(conn);
                }
                total = Convert.ToDecimal(total.ToString("F2"));
                string updateQuery = $"UPDATE Customer SET Balance = '{total}' WHERE CustomerID = '{id}'";
                using (SqlCommand command = new SqlCommand(updateQuery, conn))
                {
                    command.CommandType = CommandType.Text;
                    Connect(conn);
                    command.ExecuteNonQuery();
                    Disconnect(conn);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        #endregion
        #region TestData
        private void LoadTestData()
        {
            int[] id = new int[3];
            SqlConnection conn = new SqlConnection(cntStrng);
            Connect(conn);
            string[,] custData = new string[,] { {"Joes Signs", "Company", "393 Smith Street", "", "Springfield", "MO", "56422" },
                                                 {"Andrew Miller", "Private", "455 Kansas Exsp", "Suite 3442", "Springfield", "MO", "56426" },
                                                 {"Austins Signs", "Company", "1244 Glenstone", "Suite 2111", "Springfield", "MO", "21441"} };

            string[,] invData = new string[,] { {"1552", "1", "false", "216.18", "4/2/2020", "Check", "A255531671136" },
                                                {"1553", "2", "true", "199.98", "4/3/2020", "Cash", "" },
                                                {"1554", "3", "false", "216.18", "4/4/2020", "Cash", "" } };

            string[,] itemData = new string[,] { {"1552", "New Job", "2", "", "99.99" },
                                                 {"1553", "New Job", "1", "", "99.99" },
                                                 {"1553", "Labor", "1", "", "99.99" },
                                                 {"1554", "New Job", "2", "", "99.99" } };

            //Add test customers to database
            try
            {
                for (int i = 0; i < custData.GetLength(0); i++)
                {

                    string query = $"INSERT INTO Customer(CompanyName, JobType, AddressLine1, AddressLine2, City, State, Zip)" +
                        $"VALUES ('{custData[i, 0]}', '{custData[i, 1]}', '{custData[i, 2]}', '{custData[i, 3]}', '{custData[i, 4]}', '{custData[i, 5]}', '{custData[i, 6]}');";
                    string idQuery = $"SELECT CustomerID FROM Customer WHERE CompanyName = '{custData[i, 0]}'";
                    try
                    {
                        //Add customer to database
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                        //Gets identity Id from added customer
                        using (SqlCommand command = new SqlCommand(idQuery, conn))
                        {
                            command.CommandType = CommandType.Text;
                            id[i] = Convert.ToInt32(command.ExecuteScalar());
                            //MessageBox.Show(id.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = ex.Message + " Customer insert error";
                    }
                }

                for (int i = 0; i < invData.GetLength(0); i++)
                {
                    string query = $"INSERT INTO Invoice(InvoiceID, CustomerID, TaxExempt, Total, DateIssued, PaymentMethod, CheckNum)" +
                        $"VALUES ('{invData[i, 0]}', '{id[i]}', '{invData[i, 2]}', '{invData[i, 3]}', '{invData[i, 4]}', '{invData[i, 5]}', '{invData[i, 6]}');";
                    try
                    {
                        //Add customer to database
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                        UpdateBalance(Convert.ToInt32(id[i]));
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = ex.Message + " Invoice insert error";
                    }
                }

                for (int i = 0; i < itemData.GetLength(0); i++)
                {
                    string query = $"INSERT INTO Item(InvoiceID, ItemCode, Quantity, Description, PriceEach)" +
                    $"VALUES ('{itemData[i, 0]}', '{itemData[i, 1]}', '{itemData[i, 2]}', '{itemData[i, 3]}', '{itemData[i, 4]}');";
                    try
                    {
                        //Add customer to database
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = ex.Message + " Item insert error";
                    }
                }

                lblStatus.Text = "Added Test Data";

                FillCustomersTab();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }

            Disconnect(conn);
        }

        #endregion
        #region PanelRotation
        private void btnShowAddInvoice_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelAddInvoice.Show();
        }

        private void btnShowManageInvoice_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelManageInvoices.Show();
        }

        private void btnShowTransactions_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelTransactions.Show();
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelCustomers.Show();
        }

        private void HidePanels()
        {
            panelAddInvoice.Hide();
            panelManageInvoices.Hide();
            panelTransactions.Hide();
            panelCustomers.Hide();
        }
        #endregion
        private void txtBxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers to be typed in zip code txtbox
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            LoadTestData();
        }

        private void FillCustomersTab()
        {
            try
            {
                this.customerTableAdapter.FillBy1(this.database1DataSet1.Customer);
                dataGridViewCustomer.Sort(dataGridViewCustomer.Columns[1], 0);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(cntStrng);
            //try
            //{
            //    Connect(conn);
            //    lblStatus.Text = "Connection Successful";
            //}
            //catch (Exception ex)
            //{
            //    lblStatus.Text = "Connection Failed";
            //}
            //finally
            //{
            //    Disconnect(conn);
            //}
        }

        private void SaveDataGrid()
        {
            //This is my rough draft for saving the dataGrid
            DataSet changes = this.database1DataSet1.GetChanges();
            if (changes != null)
            {
                int updatedRow = this.customerTableAdapter.Update(database1DataSet1);
                this.database1DataSet1.AcceptChanges();
            }
        }

        private void btnSaveDataGrid_Click(object sender, EventArgs e)
        {
            SaveDataGrid();
        }
        //global variables for passing information between multiple forms
        public static string selectedCustomerName;
        public static string outstandingBalance;

        private void btnCustomerPayment_Click(object sender, EventArgs e)
        {
            //on clicking detect the row the user has selected and open new customer payment with remaining balance information
            int rowIndex;
            rowIndex = dataGridViewCustomer.CurrentCell.RowIndex;
            selectedCustomerName = dataGridViewCustomer.CurrentRow.Cells[1].Value.ToString();
            outstandingBalance = dataGridViewCustomer.CurrentRow.Cells[7].Value.ToString();
            CustomerPayment paymentForm = new CustomerPayment();
            paymentForm.Show();
        }

        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
