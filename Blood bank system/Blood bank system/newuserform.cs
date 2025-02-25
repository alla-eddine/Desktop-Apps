using Blood_bank_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blood_bank_system
{
    public partial class newuserform : Form
    {
        private DonorsClass model;
        private Utilisateurs _usersControl;
        public newuserform(Utilisateurs usersControl)
        {
            InitializeComponent(); 
            model = new DonorsClass();
            _usersControl = usersControl;
        }


        private void AddUserBtn_Click(object sender, EventArgs e)
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
                string Command = "INSERT INTO users (user_name, user_password, user_type)" +
                                           " VALUES (@Username, @Password, @UserType)";
                var parameters = new Dictionary<string, object>
                {
                    { "@Username", Username.Text },
                    { "@Password", Password.Text },
                    { "@UserType", UserType.Text }
                };
                model.ExecuteData(Command, parameters);
                _usersControl.Refresh_Datgrid();
                Close();
            }

        }

        private void newuserform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                AddUserBtn_Click(this, KeyEventArgs.Empty);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
