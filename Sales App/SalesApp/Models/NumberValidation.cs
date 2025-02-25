using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp.Models
{
    public static class NumberValidation
    {

        public static void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, control keys (like backspace), and semicolon
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Block any other input
            }
        }
    }
}
