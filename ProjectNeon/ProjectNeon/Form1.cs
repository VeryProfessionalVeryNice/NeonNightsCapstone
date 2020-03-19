using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ProjectNeon
{
    public partial class Form1 : Form
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
