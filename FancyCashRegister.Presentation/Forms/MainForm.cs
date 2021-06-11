using FancyCashRegister.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FancyCashRegister.Domain.Models;
using FancyCashRegister.Services.Data;
using FancyCashRegister.Services.Helpers;

namespace FancyCashRegister.Forms
{
    public partial class MainForm : Form
    {
        private readonly ProductenRepository _productenRepo;
        private Order _actieveOrder;

        public MainForm()
        {
            InitializeComponent();
            _productenRepo = new ProductenRepository();
        }

        public void Reset()
        {
            _actieveOrder = new Order();

            // TODO: <BindingSource|DataGrid>.DataSource = null nodig, maar voelt incorrect...
            bsProductCategorieen.DataSource = null;
            bsProductCategorieen.DataSource = _productenRepo.Categorieen;
            dgProductCategorieen.DataSource = null;
            dgProductCategorieen.DataSource = bsProductCategorieen;

            foreach (var column in dgProductCategorieen.Columns)
            {
                var c = column as DataGridViewColumn;
                c.Width = dgProductCategorieen.Width;
            }
            bsBeschikbareProducten.DataSource = null;
            bsBeschikbareProducten.DataSource = _productenRepo.Producten;
            dgBeschikbareProducten.DataSource = null;
            dgBeschikbareProducten.DataSource = bsBeschikbareProducten;
            bsProductenInOrder.DataSource = null;
            bsProductenInOrder.DataSource = _actieveOrder.Producten;
            dgProductenInOrder.DataSource = null;
            dgProductenInOrder.DataSource = bsProductenInOrder;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Screen> screens = Screen.AllScreens;

            Rectangle bounds = screens
                .Where(s => s.Primary == true)
                .First().Bounds;

            SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            //TopMost = true;
            FormBorderStyle = FormBorderStyle.None;

            Reset();
            var klantForm = new KlantForm(bsProductenInOrder);
            OrderProductenChanged += klantForm.OrderProductenChanged;
            klantForm.Show(this);
        }

        private void dgProductCategorieen_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            var ignoreColumns = new[] { 
                nameof(ProductCategorie.Id), 
                nameof(ProductCategorie.Beschrijving), 
                nameof(ProductCategorie.IsActief), 
            };

            if (ignoreColumns.Any(x => x == e.Column.Name))
            {
                e.Column.Visible = false;
            }
        }

        private void dgBeschikbareProducten_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            var ignoreColumns = new[] { 
                nameof(Product.Id), 
                nameof(Product.Beschrijving), 
                nameof(Product.Categorie), 
                nameof(Product.IsActief), 
            };
            var alignRightColumns = new[] { 
                nameof(Product.Stuksprijs), 
            };
            var moneyColumns = new[] { 
                nameof(Product.Stuksprijs), 
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

        private void dgProductenInOrder_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            var ignoreColumns = new[] { 
                nameof(OrderProduct.Id), 
                nameof(OrderProduct.Beschrijving), 
                nameof(OrderProduct.IsActief), 
                nameof(OrderProduct.CategorieId), 
                nameof(OrderProduct.Categorie), 
            };
            var alignRightColumns = new[] { 
                nameof(OrderProduct.TotaalPrijs), 
            };
            var moneyColumns = new[] { 
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

        private void OrderProduct_Changed(OrderProduct product)
        {
            var idx = _actieveOrder.Producten.IndexOf(product);
            bsProductenInOrder_ListChanged(this, new ListChangedEventArgs(ListChangedType.ItemChanged, idx));
            
        }


        private void dgProductCategorieen_SelectionChanged(object sender, EventArgs e)
        {
            if (bsProductCategorieen.Current is ProductCategorie geselecteerdeProductCategorie)
            {
                bsBeschikbareProducten.DataSource = _productenRepo.Producten
                    .Where(p => p.Categorie.Id == geselecteerdeProductCategorie.Id);
            }
        }

        private void btnAddGeselecteerdProduct_Click(object sender, EventArgs e)
        {
            if (bsBeschikbareProducten.Current is Product geselecteeerdProduct)
            {
                var toeTeVoegenProduct = new OrderProduct()
                {
                    Id = geselecteeerdProduct.Id,
                    Naam = geselecteeerdProduct.Naam,
                    Beschrijving = geselecteeerdProduct.Beschrijving,
                    Stuksprijs = geselecteeerdProduct.Stuksprijs,
                };
                _ = int.TryParse(txtGeselecteerdProductAantal.Text, out var aantalToeTeVoegen);

                var alAanwezigProduct = _actieveOrder.Producten
                    .Where(p => p.Id == toeTeVoegenProduct.Id)
                    .FirstOrDefault();

                if (alAanwezigProduct != null)
                {
                    var idx = bsProductenInOrder.List.IndexOf(alAanwezigProduct);
                    alAanwezigProduct.Aantal += aantalToeTeVoegen;
                    bsProductenInOrder[idx] = alAanwezigProduct;
                }
                else
                {
                    toeTeVoegenProduct.Aantal = aantalToeTeVoegen;
                    bsProductenInOrder.Add(toeTeVoegenProduct);
                }
                txtOrderTotaalPrijs.Text = $"{_actieveOrder.TotaalPrijs:c2}";

            }
        }

        private void btnVerwijderGeselecteerdProduct_Click(object sender, EventArgs e)
        {
            if (bsProductenInOrder.Current is OrderProduct geselecteerdeOrderProduct)
            {
                bsProductenInOrder.RemoveCurrent();
            }
        }


        private void dgBeschikbareProducten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // TODO: eventueel custom formatting op cel niveau -->
            if (dgBeschikbareProducten.Rows[e.RowIndex].DataBoundItem != null
                && dgBeschikbareProducten.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {

            }

        }

        private void dgBeschikbareProducten_SelectionChanged(object sender, EventArgs e)
        {
            updateGeselecteerdProductVelden();
        }

        private void txtAantalProducten_TextChanged(object sender, EventArgs e)
        {
            updateGeselecteerdProductVelden(false);
        }

        private void updateGeselecteerdProductVelden(bool inclusiefAantal = true)
        {

            if (bsBeschikbareProducten.Current is Product geselecteerdProduct)
            {
                int.TryParse(txtGeselecteerdProductAantal.Text, out var aantalProducten);

                if (inclusiefAantal)
                {
                    txtGeselecteerdProductAantal.Text = "1";
                }

                txtGeselecteerdProductNaam.Text = geselecteerdProduct.Naam;
                txtGeselecteerdProductStuksprijs.Text = $"p/s: {geselecteerdProduct.Stuksprijs:c}";
                txtGeselecteerdProductTotaalPrijs.Text = $"tot: {aantalProducten * geselecteerdProduct.Stuksprijs:c}";
            }
        }

        private void txtGeselecteerdProductAantal_Click(object sender, EventArgs e)
        {
            using var dialog = new NumericInputDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtGeselecteerdProductAantal.Text = dialog.Resultaat.ToString();
                btnAddGeselecteerdProduct.Select();
            }
        }

        private void dgProductenInOrder_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            var removed = e;
        }

        private void dgProductenInOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                (e.ColumnIndex != dgProductenInOrder.Columns[nameof(OrderProduct.Plus)].Index
                && e.ColumnIndex != dgProductenInOrder.Columns[nameof(OrderProduct.Min)].Index
                && e.ColumnIndex != dgProductenInOrder.Columns[nameof(OrderProduct.Aantal)].Index))
            {
                return; // this is not the click you're looking for...
            }

            if (bsProductenInOrder.Current is OrderProduct geselecteerdeOrderProduct)
            {
                if (e.ColumnIndex == dgProductenInOrder.Columns[nameof(OrderProduct.Plus)].Index)
                {
                    geselecteerdeOrderProduct.Aantal++;
                }
                else if (e.ColumnIndex == dgProductenInOrder.Columns[nameof(OrderProduct.Min)].Index)
                {
                    geselecteerdeOrderProduct.Aantal--;
                }
                else if (e.ColumnIndex == dgProductenInOrder.Columns[nameof(OrderProduct.Aantal)].Index)
                {
                    using var dialog = new NumericInputDialog();

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        geselecteerdeOrderProduct.Aantal = dialog.Resultaat;
                    }
                }

                if (geselecteerdeOrderProduct.Aantal < 1)
                {
                    if (MessageBox.Show("Aantal is 0. Product verwijderen uit order?", "Product verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // TODO: functionaliteit in methode plaatsen -->
                        btnVerwijderGeselecteerdProduct_Click(null, null);
                        return;
                    }
                    else
                    {
                        geselecteerdeOrderProduct.Aantal = 1;
                    }
                }
                OrderProduct_Changed(geselecteerdeOrderProduct);
            }
        }

        private void btnAfronden_Click(object sender, EventArgs e)
        {
            var betalenForm = new BetalenForm(_actieveOrder);
            this.Hide();
            betalenForm.Show(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // sluit eventueel overgebleven schermen -->
            MdiChildren?.ForEach(x => x.Close());
        }

        private void btnBeheer_Click(object sender, EventArgs e)
        {
            var beheerForm = new BeheerForm();
            this.Hide();
            beheerForm.Show(this);
        }

        private void bsProductenInOrder_ListChanged(object sender, ListChangedEventArgs e)
        {
            txtOrderTotaalPrijs.Text = $"{_actieveOrder.TotaalPrijs:c2}";

            dgProductenInOrder.DataSource = null;
            dgProductenInOrder.DataSource = bsProductenInOrder;
            
            OrderProductenChanged?.Invoke(bsProductenInOrder);
        }

        public delegate void OrderProductenChangedHandler(BindingSource bindingSource);

        public event OrderProductenChangedHandler OrderProductenChanged;


        private void bsProductCategorieen_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void bsBeschikbareProducten_ListChanged(object sender, ListChangedEventArgs e)
        {

        }
    }
}
