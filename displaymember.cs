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
    public partial class displaymember : Form
    {
        public displaymember()
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
        public void refresh_datagridview()
        {
              try
              {
                  SqlCommand cmd = new SqlCommand("DisplayMember_SP", con);
                  cmd.CommandType = CommandType.StoredProcedure;
                  SqlDataAdapter DA = new SqlDataAdapter(cmd);
                  DataSet DS = new DataSet();
                  DA.Fill(DS);
                  con.Open();
                  try
                  {
                      cmd.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("         <<INVALID SQL OPERATION>> \n" + ex);
                  }
                  con.Close();
                  dataGridView1.DataSource = DS.Tables[0];
                  this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                  this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                  this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                  this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                  this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
              }
              catch (Exception ex)
              {
                  MessageBox.Show("" + ex);
              }
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refresh_datagridview();
        }


        

        private void mnametxt_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from MEMBER where Name like'" + mnametxt.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
