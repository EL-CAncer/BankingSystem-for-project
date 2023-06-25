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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunay\Documents\BankSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAmtTb.Text == "" || Convert.ToUInt32(DepoAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount to deposit");
            }
            else
            {
                
                newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where Accnum='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit");
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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }
        int oldbalance,newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            oldbalance = Convert.ToInt32  (dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
