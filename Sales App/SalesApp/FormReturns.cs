using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class FormReturns : Form
    {
        public FormReturns()
        {
            InitializeComponent();
        }

        private void BtnٌShowReturns_Click(object sender, EventArgs e)
        {
            tabReturns.SelectTab(tabReturnsShow);
        }

        private void BtnAddReturns_Click(object sender, EventArgs e)
        {
            tabReturns.SelectTab(tabReturnsAdd);
        }

        private void BtnUpdateReturns_Click(object sender, EventArgs e)
        {
            tabReturns.SelectTab(tabReturnsEdit);
        }
    }
}
