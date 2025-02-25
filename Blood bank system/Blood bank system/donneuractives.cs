using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Blood_bank_system.Models;

namespace Blood_bank_system
{
    public partial class donneuractives : UserControl
    {
        private DonorsClass model;
        public donneuractives()
        {
            InitializeComponent();
            model = new DonorsClass();
            string Command = "select register_num as Num, donor_fullname as [Nom Complet], " +
                   " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                   " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                   " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors" +
                   " where  DATEDIFF(DAY, donation_date, GETDATE()) > 92 ORDER BY register_num";
            dataGridView1.DataSource = model.LoadDataTable(Command);
            dataGridView1.ClearSelection();

            DataTable dt = new DataTable();
            Command = "SELECT DISTINCT donor_group FROM donors";
            dt = model.LoadDataTable(Command);
            GroupCombo.Items.Clear();
            GroupCombo.Items.Add("tout les group");

            foreach (DataRow row in dt.Rows)
            {
                GroupCombo.Items.Add(row["donor_group"].ToString());
            }
            
        }

        public void Refresh_Combo_Group()
        {
            DataTable dt = new DataTable();
            string Command = "SELECT DISTINCT YEAR(donation_date) AS donation_year FROM donors ORDER BY donation_year";
            dt = model.LoadDataTable(Command);
            Command = "SELECT DISTINCT donor_group FROM donors";
            dt = model.LoadDataTable(Command);
            GroupCombo.Items.Clear();
            GroupCombo.Items.Add("tout les group");

            foreach (DataRow row in dt.Rows)
            {
                GroupCombo.Items.Add(row["donor_group"].ToString());
            }
            GroupCombo.SelectedItem = "tout les group";
        }

        private void GroupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = GroupCombo.SelectedItem.ToString();
            if (selectedGroup == "tout les group")
            {
                string Command = "select register_num as Num, donor_fullname as [Nom Complet], " +
                       " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                       " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                       " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors"+
                       " where  DATEDIFF(DAY, donation_date, GETDATE()) > 92 ORDER BY register_num";
                dataGridView1.DataSource = model.LoadDataTable(Command);
                dataGridView1.ClearSelection();
            }
            else
            {
                string Command = "select register_num as Num, donor_fullname as [Nom Complet], " +
                       " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                       " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                       " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors"+
                       " where  DATEDIFF(DAY, donation_date, GETDATE()) > 92 and donor_group = @selectedGroup" +
                       " ORDER BY register_num";

                var parameters = new Dictionary<string, object>
                        {
                            { "@selectedGroup", selectedGroup }
                        };
                dataGridView1.DataSource = model.LoadDataTable(Command, parameters);
                dataGridView1.ClearSelection();
            }
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            string SearchText = SearchInput.Text.Trim();
            string Command = "select register_num as Num, donor_fullname as [Nom Complet], " +
                   " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                   " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                   " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors" +
                   " WHERE DATEDIFF(DAY, donation_date, GETDATE()) > 92 and donor_fullname like @SearchText " +
                   " ORDER BY register_num";

            var parameters = new Dictionary<string, object>
            {
                            { "@SearchText", $"%{SearchText}%" }
                        };
            dataGridView1.DataSource = model.LoadDataTable(Command, parameters);
            dataGridView1.ClearSelection();
        }
    }
}
