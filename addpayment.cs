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
//add payment form
namespace Gym_management_system
{
    public partial class addpayment : Form
    {
        public addpayment()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome obj = new welcome();
            this.Hide();
            obj.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddPayment_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@PaymentId", paymentidtxt.Text);
            cmd.Parameters.AddWithValue("@Amount", amounttxt.Text);
            if (checkBox1.Checked)
            {
                cmd.Parameters.AddWithValue("@Type", checkBox1.Text);
                checkBox2.Checked = false;
            }
            if (checkBox2.Checked)
            {
                cmd.Parameters.AddWithValue("@Type", checkBox2.Text);
                checkBox1.Checked = false;
            }
            cmd.Parameters.AddWithValue("@MemberId",pmemberidtxt.Text);
            cmd.Parameters.AddWithValue("@Date", this.date.Text);
            paymentidtxt.Text = "";
            amounttxt.Text = "";
            checkBox2.Checked = false;
            checkBox1.Checked = false;

            pmemberidtxt.Text = "";
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                addsucces.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymentidtxt.Text = "";
            amounttxt.Text = "";
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            pmemberidtxt.Text = "";
            date.MaxDate = System.DateTime.Now;
            addsucces.Hide();


        }

        private void addpayment_Load(object sender, EventArgs e)
        {
            date.MaxDate = System.DateTime.Now;
        }
    }
}
