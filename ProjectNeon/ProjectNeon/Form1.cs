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
        static SqlConnection conn = new SqlConnection(cntStrng);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Connect();
            
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

        private void Connect()
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

        private void Disconnect()
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closes database connection when the form is closed
           Disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.Customer(CompanyName, JobType, AddressLine1, AddressLine2, City, State, Zip)" +
                "VALUES ('Joes Signs', 'Company', '2773 Kearny', 'Suite 17', 'Springfield', 'MO', '65706');";
            try
            {
                Connect();
                SqlCommand command = new SqlCommand(query, conn);
                //command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = "Joe's Signs";
                //command.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = "Company";
                //command.Parameters.Add("@address1", SqlDbType.VarChar, 50).Value = "2773 Kearny";
                //command.Parameters.Add("@address2", SqlDbType.VarChar, 50).Value = "Suite 17";
                //command.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = "Springfield";
                //command.Parameters.Add("@state", SqlDbType.VarChar, 2).Value = "MO";
                //command.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = "65706";

                command.ExecuteNonQuery();

                MessageBox.Show("Added Customer");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Customer";
            string[] data = new string[8];
            SqlCommand command = new SqlCommand(sql, conn);

            try
            {
                Connect();
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

                    textBox1.Text += newCust.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
