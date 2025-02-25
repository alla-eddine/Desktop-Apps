using Blood_bank_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blood_bank_system
{
    public partial class edituserform : Form
    {
        private DonorsClass model;
        private Utilisateurs _usersControl;
        public edituserform(Utilisateurs usersControl)
        {
            InitializeComponent();
            model = new DonorsClass();
            _usersControl = usersControl;
            UserType.Text = Utilisateurs.SelectedRow.Cells["Type"].Value.ToString();
            Username.Text = Utilisateurs.SelectedRow.Cells["Utilisateur"].Value.ToString();
            Password.Text = Utilisateurs.SelectedRow.Cells["Motpass"].Value.ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (UserType.Text == "" || Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("L'un des champs est vide.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                var user_id = Utilisateurs.SelectedRow.Cells["Num"].Value.ToString();
                string Command = "UPDATE users SET user_name = @Username, user_password = @Password," +
                    " user_type = @UserType WHERE user_id = @UserID";
                var parameters = new Dictionary<string, object>
                {
                    { "@Username", Username.Text },
                    { "@Password", Password.Text },
                    { "@UserType", UserType.Text },
                    { "@UserID", user_id }
                };
                model.ExecuteData(Command, parameters);
                _usersControl.Refresh_Datgrid();
                Close();
            }

        }

        private void edituserform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                EditUserBtn_Click(this, KeyEventArgs.Empty);
            }
        }

    }
}
