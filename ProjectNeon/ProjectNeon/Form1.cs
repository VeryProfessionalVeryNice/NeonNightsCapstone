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

        private string cntStrng = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                              @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
                              "Integrated Security=True;";
        private SqlConnection conn;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
            
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
            conn = new SqlConnection(cntStrng);
            conn.Open();
            //MessageBox.Show("Success");
        }

        private void CloseConnection()
        {
            conn.Close();
            //MessageBox.Show("Closed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closes database connection when the form is closed
            CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.Customer()";
        }
    }
}
