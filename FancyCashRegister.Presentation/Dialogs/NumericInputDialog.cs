using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FancyCashRegister.Dialogs
{
    public enum SoortInvoer
    {
        INTEGER = 0,
        DECIMAL = 1
    }

    public partial class NumericInputDialog : Form
    {
        private readonly bool _negatiefToestaan;
        private string _decimalSeparator = ",";

        public SoortInvoer SoortInvoer { get; init; }
        public string DecimalSeparator
        {
            get => _decimalSeparator; 
            set
            {
                _decimalSeparator = value;
                txtSeparator.Text = _decimalSeparator;
            }
        }
        public NumericInputDialog(int defaultNummer = 1, bool negatiefToestaan = false, SoortInvoer soortInvoer = SoortInvoer.INTEGER)
        {
            InitializeComponent();
            txtInvoer.Text = defaultNummer.ToString();
            txtInvoer.Select();
            _negatiefToestaan = negatiefToestaan;
            txtSeparator.Text = DecimalSeparator;
            SoortInvoer = soortInvoer;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (int.TryParse(btn.Text, out var _))
            {
                wijzigInvoer(btn.Text);
                //txtInvoer.Text += btn.Text;
            }
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            var huidigeInvoer = txtInvoer.Text;

            txtInvoer.Text = huidigeInvoer.Remove(huidigeInvoer.Length - 1);

            txtInvoer.Text = huidigeInvoer.Substring(huidigeInvoer.Length - 1, 1) == DecimalSeparator
                ? huidigeInvoer.Remove(huidigeInvoer.Length - 2)
                : huidigeInvoer.Remove(huidigeInvoer.Length - 1);
        }

        public int Resultaat => Convert.ToInt32(txtInvoer.Text.Contains(DecimalSeparator) 
            ? txtInvoer.Text.Substring(0, txtInvoer.Text.IndexOf(DecimalSeparator)) 
            : txtInvoer.Text
            );

        public decimal DecimalResultaat => decimal.Parse(txtInvoer.Text);

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (string.IsNullOrWhiteSpace(txtInvoer.Text))
            {
                txtInvoer.Text = "0";
            }

            _ = decimal.TryParse(txtInvoer.Text, out var aantal);
            aantal += btn.Text == "+" ? 1 : -1;

            if (!_negatiefToestaan && aantal < 0)
            {
                MessageBox.Show("Negatief niet toegestaan", "Negatief niet toegestaan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtInvoer.Text = SoortInvoer == SoortInvoer.INTEGER 
                    ? Convert.ToInt32(aantal).ToString()
                    : aantal.ToString("d2");
            }
        }

        //private bool isGeselecteerdeTextAanwezig() => string.IsNullOrWhiteSpace(txtInvoer.SelectedText);

        private void wijzigInvoer(string nieuweInvoer)
        {
            var geselecteerdeText = txtInvoer.SelectedText;

            if (!string.IsNullOrWhiteSpace(geselecteerdeText))
            {
                txtInvoer.SelectedText = nieuweInvoer;
            }
            else
            {
                txtInvoer.Text += nieuweInvoer;
            }
        }

        private void txtSeparator_Click(object sender, EventArgs e)
        {
            var huidigeInvoer = txtInvoer.Text;
            //huidigeInvoer.Replace(DecimalSeparator, string.Empty);
            huidigeInvoer += DecimalSeparator;
            txtInvoer.Text = huidigeInvoer;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
