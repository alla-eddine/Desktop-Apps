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
    public partial class frm_SaleQty : Form
    {
        public frm_SaleQty()
        {
            InitializeComponent();
        }

        private void frm_SaleQty_Load(object sender, EventArgs e)
        {
            TxtQty.Text = (Properties.Settings.Default.Item_Qty).ToString();
            TxtSalePrice.Text = (Properties.Settings.Default.Item_SalePrice).ToString();
            TxtDiscount.Text = (Properties.Settings.Default.Item_Discount).ToString();

            TxtQty.Focus();
        }


        private void BtnEditQty_Click(object sender, EventArgs e)
        {
            if (TxtQty.Text == "") { MessageBox.Show("من فضلك أدخل الكمية", "تأكيد"); return; }
            if (TxtSalePrice.Text == "") { MessageBox.Show("من فضلك أدخل السعر", "تأكيد"); return; }
            if (TxtDiscount.Text == "") { MessageBox.Show("من فضلك أدخل الخصم", "تأكيد"); return; }

            Properties.Settings.Default.Item_Qty = Convert.ToDecimal(TxtQty.Text);
            Properties.Settings.Default.Item_SalePrice = Convert.ToDecimal(TxtSalePrice.Text);
            Properties.Settings.Default.Item_Discount = Convert.ToDecimal(TxtDiscount.Text);


            Properties.Settings.Default.Save();

            Close();
        }


        private void frm_SaleQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (TxtQty.Text == "") { MessageBox.Show("من فضلك أدخل الكمية", "تأكيد"); return; }
                if (TxtSalePrice.Text == "") { MessageBox.Show("من فضلك أدخل السعر", "تأكيد"); return; }
                if (TxtDiscount.Text == "") { MessageBox.Show("من فضلك أدخل الخصم", "تأكيد"); return; }

                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(TxtQty.Text);
                Properties.Settings.Default.Item_SalePrice = Convert.ToDecimal(TxtSalePrice.Text);
                Properties.Settings.Default.Item_Discount = Convert.ToDecimal(TxtDiscount.Text);


                Properties.Settings.Default.Save();

                Close();
            }
        }


        

        private void frm_SaleQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //int index = FormSales.GetFormSales.DGVSales.SelectedRows[0].Index;
                int index = FormSales.GetFormSales.DGVSales.SelectedRows[0].Index;


                FormSales.GetFormSales.DGVSales.Rows[index].Cells[2].Value = Properties.Settings.Default.Item_Qty;
                FormSales.GetFormSales.DGVSales.Rows[index].Cells[3].Value = Properties.Settings.Default.Item_SalePrice;
                FormSales.GetFormSales.DGVSales.Rows[index].Cells[4].Value = Properties.Settings.Default.Item_Discount;

                MessageBox.Show(index.ToString());

            }
            catch (Exception )
            {
                
            }
        }
    }
}
