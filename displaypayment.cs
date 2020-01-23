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

namespace Gym_management_system
{
    public partial class displaypayment : Form
    {
        public displaypayment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome obj = new welcome();
            this.Hide();
            obj.Show();
        }


        private void paymentidtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int done = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select PaymentId,Amount,Type,MemberId,Date from PAYMENT where PaymentId=@PaymentId", con);
                cmd.Parameters.AddWithValue("@PaymentId", paymentidtxt.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    done = 1;
                    paymentidtxt.Text = dr.GetValue(0).ToString();
                    amounttxt.Text = dr.GetValue(1).ToString();
                    typetxt.Text = dr.GetValue(2).ToString();
                    memberidtxt.Text = dr.GetValue(3).ToString();
                    datetxt.Text = dr.GetValue(4).ToString();

                }
                con.Close();
                if(done==1)
                {
                    paymentidtxt.Show();
                    amounttxt.Show();
                    typetxt.Show();
                    memberidtxt.Show();
                    datetxt.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label7.Show();
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("invalid sql argument" + ex);
            }
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            paymentidtxt.Text = "";
            amounttxt.Text = "";
            typetxt.Text = "";
            memberidtxt.Text = "";
            datetxt.Text = "";
            datetxt.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

    }
}
