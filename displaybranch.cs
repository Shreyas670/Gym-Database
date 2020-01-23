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
//display branch info form
namespace Gym_management_system
{
    public partial class displaybranch : Form
    {
        public displaybranch()
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

        private void button3_Click(object sender, EventArgs e)
        {
            int done = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select BranchId,Name,Contact,Address,MgrId from BRANCH where BranchId=@BranchId", con);
                cmd.Parameters.AddWithValue("@BranchId", disbranchidtxt.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                nobranch.Hide();
              
                while(dr.Read())
                {
                    disbranchidtxt.Text = dr.GetValue(0).ToString();
                    nametxt.Text = dr.GetValue(1).ToString();
                    contacttxt.Text = dr.GetValue(2).ToString();
                    addresstxt.Text = dr.GetValue(3).ToString();
                    mgridtxt.Text = dr.GetValue(4).ToString();
                    done = 1;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            if(done==0)
            {
                nobranch.Show();
                disbranchidtxt.Text = "";
                nametxt.Text = "";
                contacttxt.Text = "";
                addresstxt.Text = "";
                mgridtxt.Text = "";
            }


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome obj = new welcome();
            this.Hide();
            obj.Show();
        }

    }
}
