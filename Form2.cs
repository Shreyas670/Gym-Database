using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// after login Welcome Form which has sliding panel
namespace Gym_management_system
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        
        bool branchslidingexp;
        const int Maxwidth=220;
        const int Minwidth=100;
        private void button2_Click(object sender, EventArgs e)
        {
            if (branchslidingexp)
            {
                retractslidingpanelGUI();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (branchslidingexp)
            {
                slidingpanel.Width -= 30;
                if(slidingpanel.Width<=Minwidth)
                {
                    branchslidingexp = false;
                    timer1.Stop();
                    this.Refresh();
                }
            }
            else
            {
                slidingpanel.Width += 30;
                if (slidingpanel.Width >= Maxwidth)
                {
                    branchslidingexp = true;
                    timer1.Stop();
                    expandslidingpanelGUI();
                    this.Refresh();
                }
            }
        }

        public void expandslidingpanelGUI()
        {
            branchdis.Text = "Branch Info";
            trainerdis.Text = "Add Trainer";
            addtrainer.Text = "Trainer Info";
            addmember.Text = "Add Member";
            memberinfo.Text = "Member Info";
            newpayment.Text = "New Payment";
            paymentdetails.Text = "Payment Details";
            eqpdetails.Text = "Equipment";
            logoutb.Text = "Log Out";
            slidingbutton.Image = Properties.Resources.iconfinder_16_330403__1_; 
        }
        public void retractslidingpanelGUI()
        {
            branchdis.Text = "";
            trainerdis.Text = "";
            addmember.Text = "";
            addtrainer.Text = "";
            memberinfo.Text = "";
            newpayment.Text = "";
            paymentdetails.Text = "";
            eqpdetails.Text = "";
            logoutb.Text = "";
            slidingbutton.Image = Properties.Resources.iconfinder_15_330404__1_;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayequipment obj = new displayequipment();
            this.Hide();
            obj.Show();
        }

        private void branchdis_Click(object sender, EventArgs e)
        {
            displaybranch obj = new displaybranch();
            this.Hide();
            obj.Show();
        }

        private void addtrainer_Click(object sender, EventArgs e)
        {
            addtrainer obj = new addtrainer();
            this.Hide();
            obj.Show();
        }

        private void trainerdis_Click(object sender, EventArgs e)
        {
                displaytrainer obj = new displaytrainer();
                this.Hide();
                obj.Show();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            addmember obj = new addmember();
            this.Hide();
            obj.Show();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displaymember obj = new displaymember();
            this.Hide();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addpayment obj = new addpayment();
            this.Hide();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displaypayment obj = new displaypayment();
            this.Hide();
            obj.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            firstone obj = new firstone();
            this.Hide();
            obj.Show();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            retractslidingpanelGUI();
            slidingpanel.Width = 100;
        }

        private void addtrainer_Click_1(object sender, EventArgs e)
        {
            displaytrainer obj = new displaytrainer();
            this.Hide();
            obj.Show();
        }

        private void trainerdis_Click_1(object sender, EventArgs e)
        {
            addtrainer obj = new addtrainer();
            this.Hide();
            obj.Show();
        }
    }
}
