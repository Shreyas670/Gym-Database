namespace Gym_management_system
{
    partial class welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.logoutb = new System.Windows.Forms.Button();
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.trainerdis = new System.Windows.Forms.Button();
            this.addtrainer = new System.Windows.Forms.Button();
            this.paymentdetails = new System.Windows.Forms.Button();
            this.newpayment = new System.Windows.Forms.Button();
            this.memberinfo = new System.Windows.Forms.Button();
            this.addmember = new System.Windows.Forms.Button();
            this.branchdis = new System.Windows.Forms.Button();
            this.eqpdetails = new System.Windows.Forms.Button();
            this.slidingbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.slidingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutb
            // 
            this.logoutb.BackColor = System.Drawing.Color.Transparent;
            this.logoutb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutb.FlatAppearance.BorderSize = 0;
            this.logoutb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutb.ForeColor = System.Drawing.Color.White;
            this.logoutb.Location = new System.Drawing.Point(33, 444);
            this.logoutb.Margin = new System.Windows.Forms.Padding(0);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(167, 33);
            this.logoutb.TabIndex = 9;
            this.logoutb.Text = "Log Out";
            this.logoutb.UseVisualStyleBackColor = false;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.Color.Transparent;
            this.slidingpanel.Controls.Add(this.trainerdis);
            this.slidingpanel.Controls.Add(this.addtrainer);
            this.slidingpanel.Controls.Add(this.paymentdetails);
            this.slidingpanel.Controls.Add(this.newpayment);
            this.slidingpanel.Controls.Add(this.memberinfo);
            this.slidingpanel.Controls.Add(this.addmember);
            this.slidingpanel.Controls.Add(this.branchdis);
            this.slidingpanel.Controls.Add(this.logoutb);
            this.slidingpanel.Controls.Add(this.eqpdetails);
            this.slidingpanel.Controls.Add(this.slidingbutton);
            this.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpanel.Location = new System.Drawing.Point(0, 0);
            this.slidingpanel.Name = "slidingpanel";
            this.slidingpanel.Size = new System.Drawing.Size(220, 497);
            this.slidingpanel.TabIndex = 10;
            // 
            // trainerdis
            // 
            this.trainerdis.BackColor = System.Drawing.Color.Transparent;
            this.trainerdis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainerdis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.trainerdis.FlatAppearance.BorderSize = 0;
            this.trainerdis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.trainerdis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.trainerdis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainerdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerdis.ForeColor = System.Drawing.Color.White;
            this.trainerdis.Location = new System.Drawing.Point(33, 149);
            this.trainerdis.Margin = new System.Windows.Forms.Padding(0);
            this.trainerdis.Name = "trainerdis";
            this.trainerdis.Size = new System.Drawing.Size(167, 36);
            this.trainerdis.TabIndex = 11;
            this.trainerdis.Text = "Trainer Info";
            this.trainerdis.UseVisualStyleBackColor = false;
            this.trainerdis.Click += new System.EventHandler(this.trainerdis_Click_1);
            // 
            // addtrainer
            // 
            this.addtrainer.BackColor = System.Drawing.Color.Transparent;
            this.addtrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtrainer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addtrainer.FlatAppearance.BorderSize = 0;
            this.addtrainer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addtrainer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addtrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrainer.ForeColor = System.Drawing.Color.White;
            this.addtrainer.Location = new System.Drawing.Point(33, 103);
            this.addtrainer.Margin = new System.Windows.Forms.Padding(0);
            this.addtrainer.Name = "addtrainer";
            this.addtrainer.Size = new System.Drawing.Size(167, 36);
            this.addtrainer.TabIndex = 12;
            this.addtrainer.Text = "Add Trainer";
            this.addtrainer.UseVisualStyleBackColor = false;
            this.addtrainer.Click += new System.EventHandler(this.addtrainer_Click_1);
            // 
            // paymentdetails
            // 
            this.paymentdetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentdetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.paymentdetails.FlatAppearance.BorderSize = 0;
            this.paymentdetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.paymentdetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.paymentdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentdetails.ForeColor = System.Drawing.Color.White;
            this.paymentdetails.Location = new System.Drawing.Point(33, 351);
            this.paymentdetails.Name = "paymentdetails";
            this.paymentdetails.Size = new System.Drawing.Size(167, 35);
            this.paymentdetails.TabIndex = 13;
            this.paymentdetails.Text = "Payment Details";
            this.paymentdetails.UseVisualStyleBackColor = true;
            this.paymentdetails.Click += new System.EventHandler(this.button6_Click);
            // 
            // newpayment
            // 
            this.newpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newpayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.newpayment.FlatAppearance.BorderSize = 0;
            this.newpayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newpayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpayment.ForeColor = System.Drawing.Color.White;
            this.newpayment.Location = new System.Drawing.Point(33, 301);
            this.newpayment.Name = "newpayment";
            this.newpayment.Size = new System.Drawing.Size(167, 35);
            this.newpayment.TabIndex = 12;
            this.newpayment.Text = "New Payment";
            this.newpayment.UseVisualStyleBackColor = true;
            this.newpayment.Click += new System.EventHandler(this.button5_Click);
            // 
            // memberinfo
            // 
            this.memberinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberinfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.memberinfo.FlatAppearance.BorderSize = 0;
            this.memberinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.memberinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.memberinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberinfo.ForeColor = System.Drawing.Color.White;
            this.memberinfo.Location = new System.Drawing.Point(33, 249);
            this.memberinfo.Name = "memberinfo";
            this.memberinfo.Size = new System.Drawing.Size(167, 35);
            this.memberinfo.TabIndex = 11;
            this.memberinfo.Text = "Member Info";
            this.memberinfo.UseVisualStyleBackColor = true;
            this.memberinfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // addmember
            // 
            this.addmember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addmember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addmember.FlatAppearance.BorderSize = 0;
            this.addmember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addmember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmember.ForeColor = System.Drawing.Color.White;
            this.addmember.Location = new System.Drawing.Point(33, 197);
            this.addmember.Name = "addmember";
            this.addmember.Size = new System.Drawing.Size(167, 35);
            this.addmember.TabIndex = 10;
            this.addmember.Text = "Add Member";
            this.addmember.UseVisualStyleBackColor = true;
            this.addmember.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchdis
            // 
            this.branchdis.BackColor = System.Drawing.Color.Transparent;
            this.branchdis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branchdis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.branchdis.FlatAppearance.BorderSize = 0;
            this.branchdis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.branchdis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.branchdis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branchdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchdis.ForeColor = System.Drawing.Color.White;
            this.branchdis.Location = new System.Drawing.Point(33, 56);
            this.branchdis.Margin = new System.Windows.Forms.Padding(0);
            this.branchdis.Name = "branchdis";
            this.branchdis.Size = new System.Drawing.Size(167, 36);
            this.branchdis.TabIndex = 4;
            this.branchdis.Text = "Branch Info";
            this.branchdis.UseVisualStyleBackColor = false;
            this.branchdis.Click += new System.EventHandler(this.branchdis_Click);
            // 
            // eqpdetails
            // 
            this.eqpdetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eqpdetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eqpdetails.FlatAppearance.BorderSize = 0;
            this.eqpdetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eqpdetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eqpdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqpdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqpdetails.ForeColor = System.Drawing.Color.White;
            this.eqpdetails.Location = new System.Drawing.Point(33, 392);
            this.eqpdetails.Name = "eqpdetails";
            this.eqpdetails.Size = new System.Drawing.Size(167, 32);
            this.eqpdetails.TabIndex = 1;
            this.eqpdetails.Text = "Equipment";
            this.eqpdetails.UseVisualStyleBackColor = true;
            this.eqpdetails.Click += new System.EventHandler(this.button3_Click);
            // 
            // slidingbutton
            // 
            this.slidingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidingbutton.FlatAppearance.BorderSize = 0;
            this.slidingbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.slidingbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.slidingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingbutton.ForeColor = System.Drawing.Color.White;
            this.slidingbutton.Image = global::Gym_management_system.Properties.Resources.iconfinder_16_330403__1_;
            this.slidingbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slidingbutton.Location = new System.Drawing.Point(0, 3);
            this.slidingbutton.Name = "slidingbutton";
            this.slidingbutton.Size = new System.Drawing.Size(220, 51);
            this.slidingbutton.TabIndex = 0;
            this.slidingbutton.UseVisualStyleBackColor = true;
            this.slidingbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(469, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "ADMIN";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slidingpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.slidingpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Button branchdis;
        private System.Windows.Forms.Button eqpdetails;
        private System.Windows.Forms.Button slidingbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button paymentdetails;
        private System.Windows.Forms.Button newpayment;
        private System.Windows.Forms.Button memberinfo;
        private System.Windows.Forms.Button addmember;
        private System.Windows.Forms.Button trainerdis;
        private System.Windows.Forms.Button addtrainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}