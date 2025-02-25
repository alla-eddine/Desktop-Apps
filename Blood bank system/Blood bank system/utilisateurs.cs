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

namespace Blood_bank_system
{
    public partial class Utilisateurs : UserControl
    {
        private DonorsClass model;
        public static DataGridViewRow SelectedRow { get; set; }
        public Utilisateurs()
        {
            InitializeComponent();
            model = new DonorsClass();
            Refresh_Datgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                SelectedRow = dataGridView1.Rows[e.RowIndex];

            }
        }

        private void DeleteuserBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.", "Aucun enregistrement sélectionné",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
        
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?",
                                                        "Confirmer la suppression",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var user_id = SelectedRow.Cells["Num"].Value.ToString();
                    string Command = "DELETE FROM users WHERE user_id = @user_id";
                    var parameters = new Dictionary<string, object>
                        {
                            { "@user_id", user_id }
                        };
                    model.ExecuteData(Command, parameters);
                    Refresh_Datgrid();
                }
            }
        }

        private void newuserBtn_Click(object sender, EventArgs e)
        {
            newuserform f = new newuserform(this);
            f.ShowDialog();
        }
        public void Refresh_Datgrid()
        {
            string Command = "select user_id as [Num], user_name as [Utilisateur]," +
                        " user_password as [Motpass], user_type as [Type] from users";
            dataGridView1.DataSource = model.LoadDataTable(Command);
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void EdituserBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.", "Aucun utilisateur sélectionné",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                edituserform f = new edituserform(this);
                f.ShowDialog();
            }
        }
    }
}
