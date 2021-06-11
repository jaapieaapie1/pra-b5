using FancyCashRegister.Dialogs;
using FancyCashRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FancyCashRegister.Forms
{
    public partial class BetalenForm : Form
    {
        private readonly Order _order;
        private readonly MainForm _mainForm;
        private readonly KlantForm _klantForm;

        public BetalenForm(Order order)
        {
            InitializeComponent();
            
            if (order == null)
            {
                MessageBox.Show("Fout opgetreden: Geen order om te betalen.", "Geen order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _order = order;
            _klantForm = Application.OpenForms.OfType<KlantForm>().FirstOrDefault();
            _mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
        }

        private void BetalenForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Screen> screens = Screen.AllScreens;

            Rectangle bounds = screens
                .Where(s => s.Primary == true)
                .First().Bounds;

            SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            //TopMost = true;
            FormBorderStyle = FormBorderStyle.None;

            dgProductenInOrder.AutoGenerateColumns = false;
            dgProductenInOrder.DataSource = _order.Producten;
            txtTeBetalen.Text = $"{_order.TotaalPrijs:c2}";
            // teBetalen in klantscherm gebruikt eigen logica -->
            //txtTeBetalen.TextChanged += _klantForm.TeBetalenChanged;

            txtOntvangen.TextChanged += _klantForm.OntvangenChanged;
            txtTeruggave.TextChanged += _klantForm.TeruggaveChanged;


            // afronden pas mogelijk maken als een bedrag ontvangen is -->
            btnAfgerond.Enabled = false;
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            Close();
        }

        private void btnAfgerond_Click(object sender, EventArgs e)
        {
            _order.Betaald = true;
            _klantForm.Reset();
            _mainForm.Reset();
            _mainForm.Show();
            Close();
        }
        private void dgProductenInOrder_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            var ignoreColumns = new[] { 
                nameof(OrderProduct.Id), 
                nameof(OrderProduct.Beschrijving) 
            };
            var alignRightColumns = new[] { 
                nameof(OrderProduct.Stuksprijs), 
                nameof(OrderProduct.TotaalPrijs), 
            };
            var moneyColumns = new[] { 
                nameof(OrderProduct.Stuksprijs), 
                nameof(OrderProduct.TotaalPrijs), 
            };

            if (ignoreColumns.Any(x => x == e.Column.Name))
            {
                e.Column.Visible = false;
            }

            if (alignRightColumns.Any(x => x == e.Column.Name))
            {
                e.Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (moneyColumns.Any(x => x == e.Column.Name))
            {
                e.Column.DefaultCellStyle.Format = "c2";
            }
        }

        private void dgProductenInOrder_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtOntvangen_Click(object sender, EventArgs e)
        {
            using var dialog = new NumericInputDialog(soortInvoer:SoortInvoer.DECIMAL);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOntvangen.Text = dialog.DecimalResultaat.ToString();
                btnAfgerond.Select();
            }
        }

        private void txtOntvangen_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtOntvangen.Text, out var ontvangenBedrag))
            {
                var teruggaveBedrag = ontvangenBedrag - _order.TotaalPrijs;
                txtTeruggave.Text = $"{teruggaveBedrag:c2}";

                if (teruggaveBedrag < 0)
                {
                    //if (MessageBox.Show("Ontvangen bedrag minder dan order prijs", "Negatief bedrag", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    //{
                    //    btnAfgerond.Enabled = true;
                    //}
                    //else
                    //{

                    //}
                }
                btnAfgerond.Enabled = true;
            }
            else
            {
                btnAfgerond.Enabled = false;
            }
        }

        private void txtTeBetalen_TextChanged(object sender, EventArgs e)
        {

        }

        private void BetalenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm?.Show();
            //Owner?.Show();
        }

        private void txtKortingsCode_Click(object sender, EventArgs e)
        {
            using var dialog = new NumericInputDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtKortingsCode.Text = dialog.Resultaat.ToString();
                btnActiveerKortingsCode.Select();
            }
        }

        private void btnActiveerKortingsCode_Click(object sender, EventArgs e)
        {
            // controleer of kortingscode geldig is (bestaat EN op dit moment actief)
            // configureer korting in order
        }
    }
}
