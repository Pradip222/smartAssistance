namespace smartAssistance
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnewuser = new System.Windows.Forms.Label();
            this.lbfirstn = new System.Windows.Forms.Label();
            this.lbmiddlen = new System.Windows.Forms.Label();
            this.lblastn = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbemailid = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbmoblieno = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.butsubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbnewuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::smartAssistance.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1826, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbnewuser
            // 
            this.lbnewuser.AutoSize = true;
            this.lbnewuser.ForeColor = System.Drawing.Color.Maroon;
            this.lbnewuser.Location = new System.Drawing.Point(522, 18);
            this.lbnewuser.Name = "lbnewuser";
            this.lbnewuser.Size = new System.Drawing.Size(733, 66);
            this.lbnewuser.TabIndex = 0;
            this.lbnewuser.Text = "NEW USER REGISTRATION";
            // 
            // lbfirstn
            // 
            this.lbfirstn.AutoSize = true;
            this.lbfirstn.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfirstn.Location = new System.Drawing.Point(239, 172);
            this.lbfirstn.Name = "lbfirstn";
            this.lbfirstn.Size = new System.Drawing.Size(196, 39);
            this.lbfirstn.TabIndex = 1;
            this.lbfirstn.Text = "First Name:";
            // 
            // lbmiddlen
            // 
            this.lbmiddlen.AutoSize = true;
            this.lbmiddlen.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmiddlen.Location = new System.Drawing.Point(202, 243);
            this.lbmiddlen.Name = "lbmiddlen";
            this.lbmiddlen.Size = new System.Drawing.Size(233, 39);
            this.lbmiddlen.TabIndex = 2;
            this.lbmiddlen.Text = "Middle Name:";
            // 
            // lblastn
            // 
            this.lblastn.AutoSize = true;
            this.lblastn.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblastn.Location = new System.Drawing.Point(245, 312);
            this.lblastn.Name = "lblastn";
            this.lblastn.Size = new System.Drawing.Size(190, 39);
            this.lblastn.TabIndex = 3;
            this.lblastn.Text = "Last Name:";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.Location = new System.Drawing.Point(335, 378);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(100, 39);
            this.lbdob.TabIndex = 4;
            this.lbdob.Text = "DOB:";
            // 
            // lbemailid
            // 
            this.lbemailid.AutoSize = true;
            this.lbemailid.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemailid.Location = new System.Drawing.Point(806, 312);
            this.lbemailid.Name = "lbemailid";
            this.lbemailid.Size = new System.Drawing.Size(158, 39);
            this.lbemailid.TabIndex = 5;
            this.lbemailid.Text = "Email Id:";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(791, 378);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(173, 39);
            this.lbpassword.TabIndex = 6;
            this.lbpassword.Text = "Password:";
            // 
            // lbmoblieno
            // 
            this.lbmoblieno.AutoSize = true;
            this.lbmoblieno.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmoblieno.Location = new System.Drawing.Point(779, 245);
            this.lbmoblieno.Name = "lbmoblieno";
            this.lbmoblieno.Size = new System.Drawing.Size(185, 39);
            this.lbmoblieno.TabIndex = 7;
            this.lbmoblieno.Text = "Moblie No:";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgender.Location = new System.Drawing.Point(825, 172);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(139, 39);
            this.lbgender.TabIndex = 8;
            this.lbgender.Text = "Gender:";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(450, 169);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(238, 46);
            this.txtFname.TabIndex = 9;
            this.txtFname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.Location = new System.Drawing.Point(450, 244);
            this.txtMname.Multiline = true;
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(238, 46);
            this.txtMname.TabIndex = 10;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(450, 312);
            this.txtLname.Multiline = true;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(238, 46);
            this.txtLname.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(444, 378);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(244, 46);
            this.txtDate.TabIndex = 12;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(983, 176);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(272, 47);
            this.cmbGender.TabIndex = 13;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(983, 386);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(272, 38);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(983, 311);
            this.txtemailid.Multiline = true;
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(272, 38);
            this.txtemailid.TabIndex = 15;
            this.txtemailid.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtemailid.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // txtMob
            // 
            this.txtMob.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMob.Location = new System.Drawing.Point(983, 246);
            this.txtMob.Multiline = true;
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(272, 38);
            this.txtMob.TabIndex = 16;
            // 
            // butsubmit
            // 
            this.butsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butsubmit.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsubmit.ForeColor = System.Drawing.Color.Maroon;
            this.butsubmit.Location = new System.Drawing.Point(545, 504);
            this.butsubmit.Name = "butsubmit";
            this.butsubmit.Size = new System.Drawing.Size(369, 62);
            this.butsubmit.TabIndex = 17;
            this.butsubmit.Text = "Register";
            this.butsubmit.UseVisualStyleBackColor = true;
            this.butsubmit.Click += new System.EventHandler(this.butsubmit_Click);
            this.butsubmit.MouseEnter += new System.EventHandler(this.Butsubmit_MouseEnter);
            this.butsubmit.MouseLeave += new System.EventHandler(this.Butsubmit_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 66F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1664, 833);
            this.Controls.Add(this.butsubmit);
            this.Controls.Add(this.txtMob);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbmoblieno);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbemailid);
            this.Controls.Add(this.lbdob);
            this.Controls.Add(this.lblastn);
            this.Controls.Add(this.lbmiddlen);
            this.Controls.Add(this.lbfirstn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnewuser;
        private System.Windows.Forms.Label lbfirstn;
        private System.Windows.Forms.Label lbmiddlen;
        private System.Windows.Forms.Label lblastn;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbemailid;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbmoblieno;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.Button butsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

