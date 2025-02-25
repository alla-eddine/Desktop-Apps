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
    public partial class frm_BuyQty : Form
    {
        public frm_BuyQty()
        {
            InitializeComponent();
        }


        private void frm_BuyQty_Load(object sender, EventArgs e)
        {
            TxtQty.Text = (Properties.Settings.Default.Item_Qty).ToString();
            TxtBuyPrice.Text = (Properties.Settings.Default.Item_BuyPrice).ToString();
            TxtDiscount.Text = (Properties.Settings.Default.Item_Discount).ToString();

            TxtQty.Focus();
        }


        

        private void frm_BuyQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtQty.Text == "") { MessageBox.Show("من فضلك أدخل الكمية", "تأكيد"); return; }
                if (TxtBuyPrice.Text == "") { MessageBox.Show("من فضلك أدخل السعر", "تأكيد"); return; }
                if (TxtDiscount.Text == "") { MessageBox.Show("من فضلك أدخل الخصم", "تأكيد"); return; }

                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(TxtQty.Text);
                Properties.Settings.Default.Item_BuyPrice = Convert.ToDecimal(TxtBuyPrice.Text);
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(TxtDiscount.Text);

                
                Properties.Settings.Default.Save();
                
                Close();
            }
        }

        

        private void BtnEditQty_Click(object sender, EventArgs e)
        {
            if (TxtQty.Text == "") { MessageBox.Show("من فضلك أدخل الكمية", "تأكيد"); return; }
            if (TxtBuyPrice.Text == "") { MessageBox.Show("من فضلك أدخل السعر", "تأكيد"); return; }
            if (TxtDiscount.Text == "") { MessageBox.Show("من فضلك أدخل الخصم", "تأكيد"); return; }

            Properties.Settings.Default.Item_Qty = Convert.ToDecimal(TxtQty.Text);
            Properties.Settings.Default.Item_BuyPrice = Convert.ToDecimal(TxtBuyPrice.Text);
            Properties.Settings.Default.Item_Discount = Convert.ToDecimal(TxtDiscount.Text);

            
            Properties.Settings.Default.Save();

            Close();
        }

        private void frm_BuyQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int index = FormPurchases.GetFormPurchases.DGVPurchases.SelectedRows[0].Index;

                FormPurchases.GetFormPurchases.DGVPurchases.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Qty;
                FormPurchases.GetFormPurchases.DGVPurchases.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_BuyPrice;
                FormPurchases.GetFormPurchases.DGVPurchases.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Discount;

            }
            catch (Exception)
            {

            }
        }
    }
}
