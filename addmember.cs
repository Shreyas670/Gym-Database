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
//add member form
namespace Gym_management_system
{
    public partial class addmember : Form
    {
        public addmember()
        {
            InitializeComponent();
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            welcome obj = new welcome();
            this.Hide();
            obj.Show();
        }
        SqlConnection con=new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            int done=0;
            SqlCommand cmd = new SqlCommand("AddMember_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            
            cmd.Parameters.AddWithValue("@MemberId",memberidtxt.Text);
            cmd.Parameters.AddWithValue("@Name", mnametxt.Text);
            cmd.Parameters.AddWithValue("@Contact", mcontacttxt.Text);
            cmd.Parameters.AddWithValue("@BranchId", mbranchidtxt.Text);
            cmd.Parameters.AddWithValue("@TrainerId", mtraineridtxt.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                addsucces.Show();
                done = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
                done = 1;
            }
            con.Close();
            if (done == 1)
            {
                memberidtxt.Text = "";
                mnametxt.Text = "";
                mcontacttxt.Text = "";
                mbranchidtxt.Text = "";
                mtraineridtxt.Text = "";
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteMember_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MemberId", memberidtxt.Text);

                con.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        delsuccess.Show();
                    }
                    else
                    {
                        MessageBox.Show("Member not Found");
                    }
                    memberidtxt.Text = "";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
                memberidtxt.Text = "";
                mnametxt.Text = "";
                mcontacttxt.Text = "";
                mbranchidtxt.Text = "";
                mtraineridtxt.Text = "";
            addsucces.Hide();
            delsuccess.Hide();
            updatesuccess.Hide();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            int done=0;

            try
            {
               
                    SqlCommand cmd = new SqlCommand("UpdateMember2_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MemberId", memberidtxt.Text);
                    cmd.Parameters.AddWithValue("@TrainerId",mtraineridtxt.Text);
                    con.Open();
                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                        updatesuccess.Show();
                            done = 1;
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct Member ID");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
                        done = 1;
                    }
                    con.Close();
                    if (done == 1)
                    {
                        memberidtxt.Text = "";
                        mnametxt.Text = "";
                        mcontacttxt.Text = "";
                        mbranchidtxt.Text = "";
                        mtraineridtxt.Text = "";
                    }
             }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
    }

