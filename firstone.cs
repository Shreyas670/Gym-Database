using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// first page ....
namespace Gym_management_system
{
    public partial class firstone : Form
    {
        public firstone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userBranchdis obj = new userBranchdis();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            about obj = new about();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contact obj = new contact();
            this.Hide();
            obj.Show();
        }
    }
    }

