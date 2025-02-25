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
    public partial class editdonorform : Form
    {
        private DonorsClass model;
        private candidats _candidatsControl;
        public editdonorform(candidats candidatsControl)
        {
            InitializeComponent();
            model = new DonorsClass();
            _candidatsControl = candidatsControl;
            candidats candidats = new candidats();

            var donor_id = candidats.SelectedRow.Cells["donor_id"].Value.ToString();
            RegisterNum.Text = candidats.SelectedRow.Cells["Num"].Value.ToString();
            NomComplet.Text = candidats.SelectedRow.Cells["Nom Complet"].Value.ToString();
            Sexe.Text = candidats.SelectedRow.Cells["Sexe"].Value.ToString();
            DateNaissance.Text = candidats.SelectedRow.Cells["Date Naissance"].Value.ToString();
            LieuNaissance.Text = candidats.SelectedRow.Cells["Lieu Naissance"].Value.ToString();
            Telephone.Text = candidats.SelectedRow.Cells["Telephone"].Value.ToString();
            Adresse.Text = candidats.SelectedRow.Cells["Adresse"].Value.ToString();
            Groupage.Text = candidats.SelectedRow.Cells["Groupage"].Value.ToString();
            DateDonne.Text = candidats.SelectedRow.Cells["Date de Donne"].Value.ToString();
            TypeDonneur.Text = candidats.SelectedRow.Cells["Type"].Value.ToString();
            Poches.Text = candidats.SelectedRow.Cells["Poche"].Value.ToString();

        }

        private void EditDonorBtn_Click(object sender, EventArgs e)
        {
            if (RegisterNum.Text == "" || NomComplet.Text == "" )
            {
                MessageBox.Show("L'un des champs est vide.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var dnss = DateNaissance.Value.ToString("yyyy/MM/dd");
            var dn = DateDonne.Value.ToString("yyyy/MM/dd");

            var donor_id = candidats.SelectedRow.Cells["donor_id"].Value.ToString();
            string Command = "UPDATE donors SET register_num = @RegisterNum, donor_fullname = @NomComplet, " +
                                "donor_sexe = @Sexe, donor_birthdate = @BirthDate, donor_birthplace = @BirthPlace, " +
                                "donor_phone = @Phone, donor_adress = @Address, donor_type = @DonorType, " +
                                "donor_poche = @Poches, donor_group = @Group, donation_date = @DonationDate " +
                                "WHERE donor_id = @DonorID";

            var parameters = new Dictionary<string, object>
            {
                { "@RegisterNum", Convert.ToInt32(RegisterNum.Text) },
                { "@NomComplet", NomComplet.Text },
                { "@Sexe", Sexe.Text },
                { "@BirthDate", dnss },
                { "@BirthPlace", LieuNaissance.Text },
                { "@Phone", Telephone.Text },
                { "@Address", Adresse.Text },
                { "@DonorType", TypeDonneur.Text },
                { "@Poches", Poches.Text },
                { "@Group", Groupage.Text },
                { "@DonationDate", dn },
                { "@DonorID", donor_id }
            };

            model.ExecuteData(Command, parameters);
            _candidatsControl.Refresh_Datgrid();
            _candidatsControl.Refresh_Combo_Years();
            Close();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void editdonorform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                EditDonorBtn_Click(this, KeyEventArgs.Empty);
            }
        }

        
    }
}
