using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_bank_system.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blood_bank_system
{
    public partial class newdonorform : Form
    {

        private DonorsClass model;
        private candidats _candidatsControl;

        public newdonorform(candidats candidatsControl)
        {
            InitializeComponent();
            model = new DonorsClass();
            _candidatsControl = candidatsControl;
        }

        private void AddDonorBtn_Click(object sender, EventArgs e)
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

            string Command = "INSERT INTO donors (register_num, donor_fullname, donor_sexe, donor_birthdate," +
                " donor_birthplace, donor_phone, donor_adress, donor_type, donor_poche, donor_group, donation_date) " +
                                "VALUES (@RegisterNum, @NomComplet, @Sexe, @BirthDate, @BirthPlace, @Phone, @Address," +
                                " @DonorType, @Poches, @Group, @DonationDate)";

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
                { "@DonationDate", dn }
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

        private void newdonorform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                AddDonorBtn_Click(this, KeyEventArgs.Empty);
            }
        }

        private void newdonorform_Load(object sender, EventArgs e)
        {
            DateDonne.Value = DateTime.Today;
        }

    }
}
