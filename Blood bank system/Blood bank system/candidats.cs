using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_bank_system.Models;

namespace Blood_bank_system
{
    public partial class candidats : UserControl
    {
        private DonorsClass model;
        public static DataGridViewRow SelectedRow { get; set; }
        public candidats()
        {
            InitializeComponent();
            
            model = new DonorsClass();

            Refresh_Datgrid();
            Refresh_Combo_Years();

        }

        public void Refresh_Combo_Years()
        {
            DataTable dt = new DataTable();
            string Command = "SELECT DISTINCT YEAR(donation_date) AS donation_year FROM donors ORDER BY donation_year";
            dt = model.LoadDataTable(Command);
            AnnesCombo.Items.Clear();
            AnnesCombo.Items.Add("tout les Annes");

            foreach (DataRow row in dt.Rows)
            {
                AnnesCombo.Items.Add(row["donation_year"].ToString());
            }

            if (AnnesCombo.Items.Count > 0)
            {
                AnnesCombo.SelectedIndex = AnnesCombo.Items.Count - 1; 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                SelectedRow = dataGridView1.Rows[e.RowIndex];

            }
        }

        private void newdonorBtn_Click(object sender, EventArgs e)
        {
            newdonorform f = new newdonorform(this);
            f.ShowDialog();
        }

        private void DeleteDonorBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement.", "Aucun enregistrement sélectionné", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                var donor_id = SelectedRow.Cells["donor_id"].Value.ToString();

                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?",
                                                        "Confirmer la suppression",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string Command = "DELETE FROM donors WHERE donor_id = @donor_id";
                    var parameters = new Dictionary<string, object>
                        {
                            { "@donor_id", donor_id }
                        };
                    model.ExecuteData(Command, parameters);

                    Refresh_Datgrid();
                    dataGridView1.Columns["donor_id"].Visible = false;
                    dataGridView1.ClearSelection();
                    Refresh_Combo_Years();
                }
            }



        }

        private void EditDonorBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || SelectedRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement.", "Aucun enregistrement sélectionné",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                editdonorform f = new editdonorform(this);
                f.ShowDialog();
            }
        }




        private void AnnesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = AnnesCombo.SelectedItem.ToString();
            if (selectedYear == "tout les Annes")
            {
                Refresh_Datgrid();
            }
            else
            {
                string Command = "select donor_id, register_num as Num, donor_fullname as [Nom Complet], " +
                       " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                       " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                       " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors"+
                       " WHERE YEAR(donation_date) = @selectedYear ORDER BY register_num DESC";

                var parameters = new Dictionary<string, object>
                        {
                            { "@selectedYear", selectedYear }
                        };
                dataGridView1.DataSource = model.LoadDataTable(Command, parameters);
                dataGridView1.Columns["donor_id"].Visible = false;
                dataGridView1.ClearSelection();
            }

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            string SearchText = SearchInput.Text;
            string Command = "select donor_id, register_num as Num, donor_fullname as [Nom Complet], " +
                   " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                   " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                   " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors"+
                   " WHERE donor_fullname like @SearchText ORDER BY register_num DESC";

            var parameters = new Dictionary<string, object>
            {
                            { "@SearchText", $"%{SearchText}%" }
                        };
            dataGridView1.DataSource = model.LoadDataTable(Command, parameters);
            dataGridView1.Columns["donor_id"].Visible = false;
            dataGridView1.ClearSelection();
        }

        public void Refresh_Datgrid()
        {
            string Command = "select donor_id,  register_num as Num, donor_fullname as [Nom Complet], " +
                " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors ORDER BY register_num DESC";
            dataGridView1.DataSource = model.LoadDataTable(Command);
            dataGridView1.Columns["donor_id"].Visible = false;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

    }
}
