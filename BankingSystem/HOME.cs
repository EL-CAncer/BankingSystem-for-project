using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            pin.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }
    }
}
