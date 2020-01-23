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
//add trainer
namespace Gym_management_system
{
    public partial class addtrainer : Form
    {
        public addtrainer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            int done=0;
            SqlCommand cmd = new SqlCommand("AddTrainer_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrainerId", traineridtxt.Text);
            cmd.Parameters.AddWithValue("@Name", tnametxt.Text);
            cmd.Parameters.AddWithValue("@Mobile", tmobiletxt.Text);
            cmd.Parameters.AddWithValue("@BranchId", tbranchidtxt.Text);
            traineridtxt.Text = "";
            tnametxt.Text = "";
            tmobiletxt.Text = "";
            tbranchidtxt.Text = "";
            deletesuccess.Hide();
            addsuccess.Hide();
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                addsuccess.Show();
                done = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
                traineridtxt.Text = "Enter Trainer ID";
                tnametxt.Text = "Enter Name";
                tmobiletxt.Text = "Enter Mobile";
                tbranchidtxt.Text = "Enter Branch ID";
            }
            con.Close();
            if (done == 1)
            {
                traineridtxt.Text = "Enter Trainer ID";
                tnametxt.Text = "Enter Name";
                tmobiletxt.Text = "Enter Mobile";
                tbranchidtxt.Text = "Enter Branch ID";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome obj = new welcome();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            traineridtxt.Text = "Enter Trainer ID";
            tnametxt.Text = "Enter Name";
            tmobiletxt.Text = "Enter Mobile";
            tbranchidtxt.Text = "Enter Branch ID";
            deletesuccess.Hide();
            addsuccess.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int done=0;

            try
            {
                SqlCommand cmd = new SqlCommand("DeleteTrainer_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainerId", traineridtxt.Text);
                traineridtxt.Text = "";
                deletesuccess.Hide();
                addsuccess.Hide();
                con.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        deletesuccess.Show();
                        done = 1;
                    }
                    else
                    {
                        MessageBox.Show("Trainer Not Found");
                        traineridtxt.Text = "Enter Trainer ID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
                    traineridtxt.Text = "Enter Trainer ID";
                    tnametxt.Text = "Enter Name";
                    tmobiletxt.Text = "Enter Mobile";
                    tbranchidtxt.Text = "Enter Branch ID";
                }
                con.Close();
                if(done==1)
                {
                    traineridtxt.Text = "Enter Trainer ID";
                    tnametxt.Text = "Enter Name";
                    tmobiletxt.Text = "Enter Mobile";
                    tbranchidtxt.Text = "Enter Branch ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void tnametxt_Click(object sender, EventArgs e)
        {
            tnametxt.Text = "";
        }

        private void tmobiletxt_Click(object sender, EventArgs e)
        {
            tmobiletxt.Text = "";
        }

        private void tbranchidtxt_Click(object sender, EventArgs e)
        {
            tbranchidtxt.Text = "";
        }

        private void traineridtxt_Click(object sender, EventArgs e)
        {
            traineridtxt.Text = "";
        }
    }
}
