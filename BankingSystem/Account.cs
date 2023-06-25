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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunay\Documents\BankSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query1 = "insert into AccountTbl values('" + AccNumTb.Text + "','" + AccNametb.Text + "','" + FanameTb.Text + "','" + dobdate.Value.Date + "','" + PhoneTb.Text + "','" + Addresstb.Text + "','" + educationcb.SelectedItem.ToString() + "','" + occupationtb.Text + "'," + pintb.Text + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
                finally
                {
                    Con.Close();
                }


            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}