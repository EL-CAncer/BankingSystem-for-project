using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }
        public static String AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunay\Documents\BankSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from AccountTbl where Accnum='" + AccNumTb.Text + "' and PIN= " + PinTb.Text + "", Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = AccNumTb.Text;
                HOME hOME = new HOME();
                hOME.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number or Pin Code");
            }

            Con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
