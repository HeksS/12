using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;UserId=postgres; Password=123;"); //<ip> is an actual ip address


            conn.Open();

            // NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataAdapter dr = new NpgsqlDataAdapter("Select * from products", conn); //I get InvalidOperationException : The connection is not open.
            DataSet a = new DataSet();
            dr.Fill(a);
            dataGridView1.DataSource = a.Tables[0];
            conn.Close();
        }
    }
}
