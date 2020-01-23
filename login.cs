using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Login form
namespace Gym_management_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            String Uname1 = "shreyas", Upass1 = "1234", Uname2 = "sai", Upass2 = "1234", name, pass;
            name = textBox2.Text;
            pass = textBox1.Text;

            if ((Uname1.Equals(name) && Upass1.Equals(pass))|| (Uname2.Equals(name) && Upass2.Equals(pass)))
            {
                label3.Hide();
                welcome obj = new welcome();
                this.Hide();
                obj.Show();
            }
            else
            {
                label3.Show();
               textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firstone obj = new firstone();
            this.Hide();
            obj.Show();
        }

        private void seen_Click(object sender, EventArgs e)
        {
            if(textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            seen.Show();
           
            textBox1.UseSystemPasswordChar = true;
        }
    }
}
