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

namespace BankingSystem
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunay\Documents\BankSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Balance from AccountTbl where AccNum='"+AccNumberlbl.Text+"'",Con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            Balancelbl.Text = "$"+ dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = HOME.AccNumber;
            getbalance();

        }

        private void AccNumberlbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME(); 
            this.Hide();
            hOME.Show();
        }
    }
}
