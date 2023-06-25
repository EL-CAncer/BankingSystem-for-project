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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunay\Documents\BankSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text =="")
            {
                MessageBox.Show("Enter and confirm the new pin");
            }
            else
            {

                //newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN=" +Pin1Tb.Text  + " where Accnum='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin change");
                    Con.Close();
                   Login home = new Login();
                   home.Show();
                   this.Hide();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
