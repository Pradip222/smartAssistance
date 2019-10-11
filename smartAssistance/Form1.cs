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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static String a = "";
        private void LlbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        

        private void LbDate_Click(object sender, EventArgs e)
        {

        }

        private void LbTime_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            String email = txtUsername.Text;
            if (email.Equals(""))
            {
                
            }
            else if (email.Contains("@") && email.Contains(".com"))
            {
              //  MessageBox.Show("Valid Username");

            }
            else
            {
                MessageBox.Show("invalid username","invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Clear();
                txtUsername.Focus();

                
            }
        }

        private void TxtPass_Validating(object sender, CancelEventArgs e)
        {
            String password = txtPass.Text;
             if (password.Equals("")) ;
            else if (password.Length < 8)
            {
                MessageBox.Show("Password should contain at least 8 Characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();

            }
            

            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\sqlexpress;Initial Catalog=Bank;Integrated Security=True;Pooling=False";
            SqlConnection conn1 = new SqlConnection(constring);
            conn1.Open();
            string command;
            SqlDataReader dr = null, rdr1 = null;
            string commandget = "SELECT * FROM Usersmart Where email= '" + txtUsername.Text + "' and pass= '" + txtPass.Text+ "'";
            SqlCommand querygetid = new SqlCommand(commandget, conn1);
            dr = querygetid.ExecuteReader();

            if (!dr.Read())
            {
                MessageBox.Show("Login Failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {
                //MessageBox.Show("Login Successfull !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaskPage ob = new TaskPage();
                
                this.Hide();
                ob.Show();
            }
            
        }
       
       
    }
}
