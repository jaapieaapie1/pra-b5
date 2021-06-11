using FancyCashRegister.Domain.Models;
using FancyCashRegister.Services.Helpers;
using FancyCashRegister.Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FancyCashRegister.Forms
{
    public partial class LoginForm : Form
    {
        private readonly GebruikersRepository _gebruikersRepo;
        private readonly Config _config;

        public LoginForm()
        {
            InitializeComponent();
            _gebruikersRepo = new GebruikersRepository();
            _config = new ConfigRepository().GetAppConfig();
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Screen> screens = Screen.AllScreens;

            Rectangle bounds = screens
                .Where(s => s.Primary == true)
                .First().Bounds;
            
            SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            //TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;

            lbGebruikers.DataSource = _gebruikersRepo.Gebruikers.ToList();
            lbGebruikers.ValueMember = nameof(Gebruiker.Id);
            lbGebruikers.DisplayMember = nameof(Gebruiker.Gebruikersnaam);
            lbGebruikers.ClearSelected();

            txtPincode.Mask = new string('0', _config.LengtePincode);
            lbGebruikers.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lbGebruikers.SelectedItem is Gebruiker geselecteerdeGebruiker)
            {
                if (!geselecteerdeGebruiker.IsActief)
                {
                    MessageBox.Show("Gebruiker is niet geactiveerd", "Niet actief", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var ingevoerdePinCorrect = new DataHelper().CheckHash(txtPincode.Text, geselecteerdeGebruiker.Pincode);

                    if (ingevoerdePinCorrect)
                    {
                        ConfigRepository.HuidigeGebruiker = geselecteerdeGebruiker;

                        new MainForm().Show(this);
                        txtPincode.Text = string.Empty;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Combinatie gebruikersnaam / pin niet gevonden", "Niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void lbGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPincode.Text = string.Empty;
            txtPincode.Select();

        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
