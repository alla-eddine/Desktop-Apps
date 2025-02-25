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
using System.Runtime.InteropServices;


namespace Blood_bank_system
{
    
    public partial class Form1 : Form
    {
        private DonorsClass model;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WS_MINIMIZEBOX = 0x20000;
        public const int CS_DBLCLKS = 0x8;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private List<Button> buttons = new List<Button>();


        public Form1()
        {
            InitializeComponent();

            headerlabel.Text = "Les Statistique de l'année " + DateTime.Now.Year.ToString();
            Mois1btn.Select();
            stats1.BringToFront();

            model = new DonorsClass();

            buttons.Add(Statsbtn);
            buttons.Add(Candidatsbtn);
            buttons.Add(Donneuractivesbtn); 
            buttons.Add(Usersbtn);
            buttons.Add(SettingsBtn);
            buttons.Add(Deconnecterbtn);

            foreach (var btn in buttons)
            {
                btn.Click += Button_Click;
            }

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            foreach (var btn in buttons)
            {
                btn.BackColor = Color.Transparent; 
            }

            if (clickedButton != null)
            {
                clickedButton.BackColor =Color.AntiqueWhite; 
            }
        }

        private void Hedearpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Hedearpanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Statsbtn_Click(object sender, EventArgs e)
        {
            headerlabel.Text = "Les Statistique de l'année " + DateTime.Now.Year.ToString();
            Mois1btn.Select();
            stats1.BringToFront();
            stats1.LoadData("CurrentMonth");
        }

        private void Candidatsbtn_Click(object sender, EventArgs e)
        {
            headerlabel.Text = "List des candidats";
            candidats1.BringToFront();


            string Command = "select donor_id, register_num as Num, donor_fullname as [Nom Complet], " +
                   " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                   " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                   " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors ORDER BY register_num DESC";
            candidats1.dataGridView1.DataSource = model.LoadDataTable(Command);
            candidats1.dataGridView1.ClearSelection();
            candidats.SelectedRow = null;
            candidats1.Refresh_Combo_Years();
        }

        private void Donneuractivesbtn_Click(object sender, EventArgs e)
        {
            headerlabel.Text = "List des donneur actives";
            donneuractives1.BringToFront();
            string Command = "select register_num as Num, donor_fullname as [Nom Complet], " +
                   " donor_group as Groupage, donation_date as [Date de Donne], donor_phone as Telephone," +
                   " donor_type as Type, donor_poche as Poche, donor_sexe as Sexe, donor_birthdate as [Date Naissance]," +
                   " donor_birthplace as [Lieu Naissance], donor_adress as Adresse from donors"+
                   " where  DATEDIFF(DAY, donation_date, GETDATE()) > 92 ORDER BY register_num DESC";

            donneuractives1.dataGridView1.DataSource = model.LoadDataTable(Command);
            donneuractives1.Refresh_Combo_Group();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            headerlabel.Text = "Paramètres et apropos ce logiciel";
            settings.BringToFront();
        }

        private void Mois3btn_Click(object sender, EventArgs e)
        {
            stats1.LoadData("CurrentQuarter");
            Mois3btn.Select();
        }

        private void Mois1btn_Click(object sender, EventArgs e)
        {
            stats1.LoadData("CurrentMonth");
            Mois1btn.Select();
        }

        private void Mois6btn_Click(object sender, EventArgs e)
        {
            stats1.LoadData("CurrentHalfYear");
            Mois6btn.Select();
        }

        private void Mois12btn_Click(object sender, EventArgs e)
        {
            stats1.LoadData("CurrentYear");
            Mois12btn.Select();
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            utilisateurs1.BringToFront();
            headerlabel.Text = "Gestion des utlisateurs";
            string Command = "select user_id as [Num], user_name as [Utilisateur]," +
                            " user_password as [Motpass], user_type as [Type] from users";
            utilisateurs1.dataGridView1.DataSource = model.LoadDataTable(Command);
            utilisateurs1.dataGridView1.ClearSelection();
            Utilisateurs.SelectedRow = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromHandle(this.Handle).WorkingArea.Size;
        }

        private void Deconnecterbtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
