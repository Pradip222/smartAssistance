using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartAssistance
{
    public partial class TaskPage : Form
    {
        public TaskPage()
        {
            InitializeComponent();
            timer1.Start();
            audio1.Visible = false;
            video1.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToShortDateString();
            lbtime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            audio1.Visible = true;
            audio1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            video1.Visible = true;
            video1.BringToFront();
        }
    }
}
