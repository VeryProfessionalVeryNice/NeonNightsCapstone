using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ProjectNeon
{
    public partial class Form1 : Form
    {

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True

        private static string cntStrng = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                               @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
                              "Integrated Security=True;";
        //Default query string for transaction tab
        string query = "SELECT Customer.CompanyName, Invoice.InvoiceID, Invoice.DateIssued, DATEDIFF(day, Invoice.DateIssued, GETDATE()) AS Aging, FORMAT(Invoice.Total, 'C2') AS Total, FORMAT(Customer.Balance, 'C2') AS Balance FROM (Invoice INNER JOIN Customer ON Invoice.CustomerID = Customer.CustomerID) WHERE(YEAR(Invoice.DateIssued) = YEAR(GETDATE())) OR (Customer.Balance > 0)";

        //global variables for passing information between multiple forms
        public static string selectedCustomerName;
        public static string outstandingBalance;
        public static string selectedInvoiceId;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FillCustomersTab();
            FillTransactionsTab(query);
            //LoadTestData(); //autoloading test data for now
        }

        private void safePDF_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string target = @"";
            }
            catch (Exception ex)
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Adds item to listbox of items
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
            //Resets all fields
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
            FillTransactionsTab(query);
            lblStatus.Text = "Added Invoice";
        }

        private int AddCustomer()
        {
            //Int to hold customer Id to tie invoice to customer
            int id = 0;

            SqlConnection conn = new SqlConnection(cntStrng);
            string query = $"INSERT INTO Customer(CompanyName, JobType, AddressLine1, AddressLine2, City, State, Zip)" +
                $"VALUES ('{txtBxName.Text}', '{cmbBxJobType.Text}', '{txtBxAddress1.Text}', '{txtBxAddress2.Text}', '{txtBxCity.Text}', '{txtBxState.Text}', '{txtBxZip.Text}');";
            string idQ = "SELECT @@IDENTITY";
            try
            {
                //Add customer to database
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandType = CommandType.Text;
                    Connect(conn);
                    command.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(idQ, conn);
                    id = Convert.ToInt32(cmd.ExecuteScalar());
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
            foreach (TextBox txtBx in textBoxes)
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

            total += GetTax(total);

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
            decimal oldTotal = 0m;
            SqlConnection conn = new SqlConnection(cntStrng);
            string sumQuery = $"SELECT SUM(Total) FROM Invoice WHERE CustomerID = '{id}'";
            string oldQuery = $"SELECT SUM(Balance) FROM Customer WHERE CustomerID = '{id}'";

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
                try
                {
                    using (SqlCommand command = new SqlCommand(oldQuery, conn))
                    {
                        command.CommandType = CommandType.Text;
                        Connect(conn);
                        oldTotal = Convert.ToDecimal(command.ExecuteScalar());
                        //MessageBox.Show(total.ToString("C2"));
                        Disconnect(conn);
                        total += oldTotal;
                    }
                }
                catch { }
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
            FillTransactionsTab(query);
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

        private void FillTransactionsTab(string qry)
        {
            //Query to fill transactions tab
            SqlConnection conn = new SqlConnection(cntStrng);
            Connect(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                //Create data adapter to fill dataset
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                //Fill dataset with data from query
                adpt.Fill(data);
                //Set datagridviews datasource to dataset
                dataGridViewTransactions.DataSource = data.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
            finally
            {
                Disconnect(conn);
            }
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.Show();
        }

        private void SaveDataGrid()
        {
            //Gets a dataset of all changes to the datagridview
            DataSet changes = this.database1DataSet1.GetChanges();
            if (changes != null)
            {
                //Gets updated rows then commits the changes
                int updatedRow = this.customerTableAdapter.Update(database1DataSet1);
                this.database1DataSet1.AcceptChanges();
            }
        }

        private void btnSaveDataGrid_Click(object sender, EventArgs e)
        {
            SaveDataGrid();
        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Makes query string to search for typed field in selected column
            string qry = $"SELECT Customer.CompanyName, Invoice.InvoiceID, Invoice.DateIssued, DATEDIFF(day, Invoice.DateIssued, GETDATE()) AS Aging, FORMAT(Invoice.Total, 'C2') AS Total, FORMAT(Customer.Balance, 'C2') AS Balance FROM (Invoice INNER JOIN Customer ON Invoice.CustomerID = Customer.CustomerID) WHERE {cmBxSearch.Text} LIKE '%{txtBxSearch.Text}%'";
            FillTransactionsTab(qry);
        }

        private void btnOpenInvoice_Click(object sender, EventArgs e)
        {
            //Get index of selected row
            int index = dataGridViewTransactions.CurrentCell.RowIndex;
            selectedInvoiceId = dataGridViewTransactions.CurrentRow.Cells[1].Value.ToString();
            string qry = $"SELECT * FROM Invoice WHERE InvoiceID = {selectedInvoiceId}";
            string qry2 = $"SELECT * FROM Item WHERE InvoiceID = {selectedInvoiceId}";
            Invoice newInvoice = new Invoice();
            Item[] items = new Item[30];
            SqlConnection conn = new SqlConnection(cntStrng);
            Connect(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                //Create data adapter to fill dataset
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                //Fill dataset with data from query
                adpt.Fill(data);
                DataTable invoiceTable = data.Tables[0];
                newInvoice.Id = invoiceTable.Rows[0]["InvoiceID"].ToString();
                newInvoice.CustomerId = Convert.ToInt32(invoiceTable.Rows[0]["CustomerID"]);
                newInvoice.TaxExempt = Convert.ToBoolean(invoiceTable.Rows[0]["TaxExempt"]);
                newInvoice.Total = Convert.ToDecimal(invoiceTable.Rows[0]["Total"]);
                newInvoice.DateIssued = Convert.ToDateTime(invoiceTable.Rows[0]["DateIssued"]);
                newInvoice.PaymentMethod = invoiceTable.Rows[0]["PaymentMethod"].ToString();
                newInvoice.CheckNum = invoiceTable.Rows[0]["CheckNum"].ToString();

                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                SqlDataAdapter adpt2 = new SqlDataAdapter(cmd2);
                DataSet data2 = new DataSet();
                adpt2.Fill(data2);
                DataTable itemTable = data2.Tables[0];
                for (int i = 0; i < itemTable.Rows.Count; i++)
                {
                    items[i] = new Item();
                    items[i].Id = Convert.ToInt32(itemTable.Rows[i]["ItemID"]);
                    items[i].InvoiceId = itemTable.Rows[i]["InvoiceID"].ToString();
                    items[i].ItemCode = itemTable.Rows[i]["ItemCode"].ToString();
                    items[i].Quantity = Convert.ToByte(itemTable.Rows[i]["Quantity"]);
                    items[i].Description = itemTable.Rows[i]["Description"].ToString();
                    items[i].PriceEach = Convert.ToDecimal(itemTable.Rows[i]["PriceEach"]);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
            finally
            {
                Disconnect(conn);
            }
            AlterInvoice alterInvoice = new AlterInvoice(cntStrng, items, newInvoice);
            alterInvoice.ShowDialog();
            FillTransactionsTab(query);
            FillCustomersTab();
        }
    }
}
