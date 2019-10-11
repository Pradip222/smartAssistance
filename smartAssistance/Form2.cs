using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartAssistance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            frmLogin.a = txtemailid.Text;
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            String email = txtemailid.Text;
            if (email.Contains("@") && email.Contains(".com"))
                MessageBox.Show("Email is valid", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Email is Invalid", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemailid.Clear();
                txtemailid.Focus();
            }
        }

        private void butsubmit_Click(object sender, EventArgs e)
        {
            /// frmLogin lo=new frmLogin;
            //lo.show();
            string constring = @"Data Source=.\sqlexpress;Initial Catalog=Bank;Integrated Security=True;Pooling=False";
            SqlConnection conn1 = new SqlConnection(constring);
            conn1.Open();
            string command;
            SqlDataReader dr = null, rdr1 = null;
            string commandget = "INSERT INTO Usersmart VALUES ('" + txtFname.Text + "','" + txtMname.Text + "','" + txtLname.Text + "','" + txtDate.Value.ToString() + "','" + cmbGender.SelectedItem.ToString() + "','" + txtMob.Text + "','" + txtemailid.Text + "','" + txtPassword.Text + "')";
            SqlCommand querygetid = new SqlCommand(commandget, conn1);
            querygetid.ExecuteNonQuery();
            
            MessageBox.Show("Registered Successfully", "sucees", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLogin.a = txtemailid.Text;
            this.Hide();
           
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            //label2.ForeColor = Color.Red;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
           // label2.ForeColor = Color.White;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        private void Butsubmit_MouseEnter(object sender, EventArgs e)
        {
            butsubmit.BackColor = Color.YellowGreen;

        }

        private void Butsubmit_MouseLeave(object sender, EventArgs e)
        {
            butsubmit.BackColor = Color.White;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fr = new frmLogin();
            fr.ShowDialog();
        }
    }
}
