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
    public partial class frm_PaySale : Form
    {
        public frm_PaySale()
        {
            InitializeComponent();
        }

        private void frm_PaySale_Load(object sender, EventArgs e)
        {
            try
            {
                TxtPaid.Focus();

                TxtRequired.Text = (Properties.Settings.Default.PriceRequired).ToString();
                TxtPaid.Text = TxtRequired.Text;

            }
            catch (Exception) { }
        }

        private void BtnPayEnter_Click(object sender, EventArgs e)
        {
            if (TxtPaid.Text == "") MessageBox.Show("يرجى إدخال المبلغ المدفوع", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                Properties.Settings.Default.PricePaid = Convert.ToDecimal(TxtPaid.Text);
                Properties.Settings.Default.PriceRest = Convert.ToDecimal(TxtRest.Text);

                Properties.Settings.Default.ChekButton = true;

                Properties.Settings.Default.Save();

                Close();
            }
        }

        

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChekButton = false;

            Properties.Settings.Default.Save();
            Close();
        }

        private void TxtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal rest = Convert.ToDecimal(TxtRequired.Text) - Convert.ToDecimal(TxtPaid.Text);
                TxtRest.Text = Math.Round(rest, 2).ToString();
            }
            catch (Exception) { }
        }

        private void frm_PaySale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtPaid.Text == "") MessageBox.Show("يرجى إدخال المبلغ المدفوع", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    Properties.Settings.Default.PricePaid = Convert.ToDecimal(TxtPaid.Text);
                    Properties.Settings.Default.PriceRest = Convert.ToDecimal(TxtRest.Text);

                    Properties.Settings.Default.ChekButton = true;

                    Properties.Settings.Default.Save();

                    Close();
                }
            }
            else if (e.KeyCode == Keys.F12)
            {
                Properties.Settings.Default.ChekButton = false;

                Properties.Settings.Default.Save();
                Close();
            }
        }
    }
}
