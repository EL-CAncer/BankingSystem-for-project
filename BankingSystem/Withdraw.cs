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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunay\Documents\BankSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            balancelbl.Text = "Balance $" + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;

        private void button1_Click(object sender, EventArgs e)
        {
            if (wdTb.Text == "")
            {
                MessageBox.Show("Missing money");
            }
            else if (Convert.ToInt32(wdTb.Text) <= 0)
            {
                MessageBox.Show("Insert money");
            }
            else if (Convert.ToInt32(wdTb.Text) > bal)
            {
                MessageBox.Show("Can't be negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdTb.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("withdraw was Success");
                        Con.Close();
                        HOME hOME = new HOME();
                        hOME.Show();
                        this.Hide();

                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }
    }
}
