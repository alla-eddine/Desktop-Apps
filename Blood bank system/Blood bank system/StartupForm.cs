using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_bank_system
{
    public partial class StartupForm : Form
    {
        private int progressValue = 0;

        public StartupForm()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue++;
                circularProgressBar1.Value = progressValue;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                LoginForm f = new LoginForm();
                f.Show();
                this.Hide();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
