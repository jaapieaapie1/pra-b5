
namespace FancyCashRegister.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgBeschikbareProducten = new System.Windows.Forms.DataGridView();
            this.lblBeschikbareProducten = new System.Windows.Forms.Label();
            this.txtGeselecteerdProductAantal = new System.Windows.Forms.TextBox();
            this.btnAddGeselecteerdProduct = new System.Windows.Forms.Button();
            this.btnVerwijderGeselecteerdProduct = new System.Windows.Forms.Button();
            this.dgProductenInOrder = new System.Windows.Forms.DataGridView();
            this.btnAfronden = new System.Windows.Forms.Button();
            this.txtGeselecteerdProductStuksprijs = new System.Windows.Forms.TextBox();
            this.txtGeselecteerdProductTotaalPrijs = new System.Windows.Forms.TextBox();
            this.txtOrderTotaalPrijs = new System.Windows.Forms.TextBox();
            this.dgProductCategorieen = new System.Windows.Forms.DataGridView();
            this.lblProductCategorieen = new System.Windows.Forms.Label();
            this.bsProductenInOrder = new System.Windows.Forms.BindingSource(this.components);
            this.txtGeselecteerdProductNaam = new System.Windows.Forms.TextBox();
            this.lblOrderProducten = new System.Windows.Forms.Label();
            this.btnBeheer = new System.Windows.Forms.Button();
            this.bsProductCategorieen = new System.Windows.Forms.BindingSource(this.components);
            this.bsBeschikbareProducten = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgBeschikbareProducten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductenInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductCategorieen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductenInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCategorieen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBeschikbareProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBeschikbareProducten
            // 
            this.dgBeschikbareProducten.AllowUserToAddRows = false;
            this.dgBeschikbareProducten.AllowUserToDeleteRows = false;
            this.dgBeschikbareProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBeschikbareProducten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgBeschikbareProducten.Location = new System.Drawing.Point(248, 39);
            this.dgBeschikbareProducten.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgBeschikbareProducten.MultiSelect = false;
            this.dgBeschikbareProducten.Name = "dgBeschikbareProducten";
            this.dgBeschikbareProducten.ReadOnly = true;
            this.dgBeschikbareProducten.RowHeadersVisible = false;
            this.dgBeschikbareProducten.RowHeadersWidth = 51;
            this.dgBeschikbareProducten.RowTemplate.Height = 50;
            this.dgBeschikbareProducten.RowTemplate.ReadOnly = true;
            this.dgBeschikbareProducten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBeschikbareProducten.Size = new System.Drawing.Size(414, 896);
            this.dgBeschikbareProducten.TabIndex = 0;
            this.dgBeschikbareProducten.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgBeschikbareProducten_CellFormatting);
            this.dgBeschikbareProducten.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgBeschikbareProducten_ColumnAdded);
            this.dgBeschikbareProducten.SelectionChanged += new System.EventHandler(this.dgBeschikbareProducten_SelectionChanged);
            // 
            // lblBeschikbareProducten
            // 
            this.lblBeschikbareProducten.AutoSize = true;
            this.lblBeschikbareProducten.Location = new System.Drawing.Point(248, 15);
            this.lblBeschikbareProducten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBeschikbareProducten.Name = "lblBeschikbareProducten";
            this.lblBeschikbareProducten.Size = new System.Drawing.Size(76, 20);
            this.lblBeschikbareProducten.TabIndex = 1;
            this.lblBeschikbareProducten.Text = "Producten";
            // 
            // txtGeselecteerdProductAantal
            // 
            this.txtGeselecteerdProductAantal.Location = new System.Drawing.Point(670, 77);
            this.txtGeselecteerdProductAantal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGeselecteerdProductAantal.Name = "txtGeselecteerdProductAantal";
            this.txtGeselecteerdProductAantal.ReadOnly = true;
            this.txtGeselecteerdProductAantal.Size = new System.Drawing.Size(132, 27);
            this.txtGeselecteerdProductAantal.TabIndex = 2;
            this.txtGeselecteerdProductAantal.Text = "1";
            this.txtGeselecteerdProductAantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGeselecteerdProductAantal.Click += new System.EventHandler(this.txtGeselecteerdProductAantal_Click);
            this.txtGeselecteerdProductAantal.TextChanged += new System.EventHandler(this.txtAantalProducten_TextChanged);
            // 
            // btnAddGeselecteerdProduct
            // 
            this.btnAddGeselecteerdProduct.Location = new System.Drawing.Point(670, 259);
            this.btnAddGeselecteerdProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddGeselecteerdProduct.Name = "btnAddGeselecteerdProduct";
            this.btnAddGeselecteerdProduct.Size = new System.Drawing.Size(135, 91);
            this.btnAddGeselecteerdProduct.TabIndex = 4;
            this.btnAddGeselecteerdProduct.Text = ">";
            this.btnAddGeselecteerdProduct.UseVisualStyleBackColor = true;
            this.btnAddGeselecteerdProduct.Click += new System.EventHandler(this.btnAddGeselecteerdProduct_Click);
            // 
            // btnVerwijderGeselecteerdProduct
            // 
            this.btnVerwijderGeselecteerdProduct.Location = new System.Drawing.Point(670, 360);
            this.btnVerwijderGeselecteerdProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnVerwijderGeselecteerdProduct.Name = "btnVerwijderGeselecteerdProduct";
            this.btnVerwijderGeselecteerdProduct.Size = new System.Drawing.Size(135, 91);
            this.btnVerwijderGeselecteerdProduct.TabIndex = 5;
            this.btnVerwijderGeselecteerdProduct.Text = "<";
            this.btnVerwijderGeselecteerdProduct.UseVisualStyleBackColor = true;
            this.btnVerwijderGeselecteerdProduct.Click += new System.EventHandler(this.btnVerwijderGeselecteerdProduct_Click);
            // 
            // dgProductenInOrder
            // 
            this.dgProductenInOrder.AllowUserToAddRows = false;
            this.dgProductenInOrder.AllowUserToDeleteRows = false;
            this.dgProductenInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductenInOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProductenInOrder.Location = new System.Drawing.Point(813, 39);
            this.dgProductenInOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgProductenInOrder.Name = "dgProductenInOrder";
            this.dgProductenInOrder.ReadOnly = true;
            this.dgProductenInOrder.RowHeadersVisible = false;
            this.dgProductenInOrder.RowHeadersWidth = 51;
            this.dgProductenInOrder.RowTemplate.Height = 50;
            this.dgProductenInOrder.RowTemplate.ReadOnly = true;
            this.dgProductenInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductenInOrder.Size = new System.Drawing.Size(526, 756);
            this.dgProductenInOrder.TabIndex = 6;
            this.dgProductenInOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductenInOrder_CellClick);
            this.dgProductenInOrder.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgProductenInOrder_ColumnAdded);
            this.dgProductenInOrder.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgProductenInOrder_ColumnRemoved);
            // 
            // btnAfronden
            // 
            this.btnAfronden.Location = new System.Drawing.Point(1203, 892);
            this.btnAfronden.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAfronden.Name = "btnAfronden";
            this.btnAfronden.Size = new System.Drawing.Size(135, 91);
            this.btnAfronden.TabIndex = 7;
            this.btnAfronden.Text = "Betalen";
            this.btnAfronden.UseVisualStyleBackColor = true;
            this.btnAfronden.Click += new System.EventHandler(this.btnAfronden_Click);
            // 
            // txtGeselecteerdProductStuksprijs
            // 
            this.txtGeselecteerdProductStuksprijs.Location = new System.Drawing.Point(670, 117);
            this.txtGeselecteerdProductStuksprijs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGeselecteerdProductStuksprijs.Name = "txtGeselecteerdProductStuksprijs";
            this.txtGeselecteerdProductStuksprijs.ReadOnly = true;
            this.txtGeselecteerdProductStuksprijs.Size = new System.Drawing.Size(132, 27);
            this.txtGeselecteerdProductStuksprijs.TabIndex = 8;
            this.txtGeselecteerdProductStuksprijs.Text = "0,00";
            this.txtGeselecteerdProductStuksprijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGeselecteerdProductTotaalPrijs
            // 
            this.txtGeselecteerdProductTotaalPrijs.Location = new System.Drawing.Point(670, 157);
            this.txtGeselecteerdProductTotaalPrijs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGeselecteerdProductTotaalPrijs.Name = "txtGeselecteerdProductTotaalPrijs";
            this.txtGeselecteerdProductTotaalPrijs.ReadOnly = true;
            this.txtGeselecteerdProductTotaalPrijs.Size = new System.Drawing.Size(132, 27);
            this.txtGeselecteerdProductTotaalPrijs.TabIndex = 9;
            this.txtGeselecteerdProductTotaalPrijs.Text = "0,00";
            this.txtGeselecteerdProductTotaalPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderTotaalPrijs
            // 
            this.txtOrderTotaalPrijs.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderTotaalPrijs.Location = new System.Drawing.Point(1176, 803);
            this.txtOrderTotaalPrijs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOrderTotaalPrijs.Name = "txtOrderTotaalPrijs";
            this.txtOrderTotaalPrijs.ReadOnly = true;
            this.txtOrderTotaalPrijs.Size = new System.Drawing.Size(162, 74);
            this.txtOrderTotaalPrijs.TabIndex = 10;
            this.txtOrderTotaalPrijs.Text = "0,00";
            this.txtOrderTotaalPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgProductCategorieen
            // 
            this.dgProductCategorieen.AllowUserToAddRows = false;
            this.dgProductCategorieen.AllowUserToDeleteRows = false;
            this.dgProductCategorieen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductCategorieen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProductCategorieen.Location = new System.Drawing.Point(14, 39);
            this.dgProductCategorieen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgProductCategorieen.MultiSelect = false;
            this.dgProductCategorieen.Name = "dgProductCategorieen";
            this.dgProductCategorieen.ReadOnly = true;
            this.dgProductCategorieen.RowHeadersVisible = false;
            this.dgProductCategorieen.RowHeadersWidth = 51;
            this.dgProductCategorieen.RowTemplate.Height = 50;
            this.dgProductCategorieen.RowTemplate.ReadOnly = true;
            this.dgProductCategorieen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductCategorieen.Size = new System.Drawing.Size(226, 896);
            this.dgProductCategorieen.TabIndex = 11;
            this.dgProductCategorieen.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgProductCategorieen_ColumnAdded);
            this.dgProductCategorieen.SelectionChanged += new System.EventHandler(this.dgProductCategorieen_SelectionChanged);
            // 
            // lblProductCategorieen
            // 
            this.lblProductCategorieen.AutoSize = true;
            this.lblProductCategorieen.Location = new System.Drawing.Point(16, 13);
            this.lblProductCategorieen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductCategorieen.Name = "lblProductCategorieen";
            this.lblProductCategorieen.Size = new System.Drawing.Size(90, 20);
            this.lblProductCategorieen.TabIndex = 12;
            this.lblProductCategorieen.Text = "Categorieën";
            // 
            // bsProductenInOrder
            // 
            this.bsProductenInOrder.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsProductenInOrder_ListChanged);
            // 
            // txtGeselecteerdProductNaam
            // 
            this.txtGeselecteerdProductNaam.Location = new System.Drawing.Point(671, 39);
            this.txtGeselecteerdProductNaam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeselecteerdProductNaam.Name = "txtGeselecteerdProductNaam";
            this.txtGeselecteerdProductNaam.ReadOnly = true;
            this.txtGeselecteerdProductNaam.Size = new System.Drawing.Size(131, 27);
            this.txtGeselecteerdProductNaam.TabIndex = 13;
            this.txtGeselecteerdProductNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrderProducten
            // 
            this.lblOrderProducten.AutoSize = true;
            this.lblOrderProducten.Location = new System.Drawing.Point(813, 12);
            this.lblOrderProducten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderProducten.Name = "lblOrderProducten";
            this.lblOrderProducten.Size = new System.Drawing.Size(132, 20);
            this.lblOrderProducten.TabIndex = 14;
            this.lblOrderProducten.Text = "Producten in order";
            // 
            // btnBeheer
            // 
            this.btnBeheer.Location = new System.Drawing.Point(672, 845);
            this.btnBeheer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBeheer.Name = "btnBeheer";
            this.btnBeheer.Size = new System.Drawing.Size(135, 91);
            this.btnBeheer.TabIndex = 15;
            this.btnBeheer.Text = "Beheer";
            this.btnBeheer.UseVisualStyleBackColor = true;
            this.btnBeheer.Click += new System.EventHandler(this.btnBeheer_Click);
            // 
            // bsProductCategorieen
            // 
            this.bsProductCategorieen.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsProductCategorieen_ListChanged);
            // 
            // bsBeschikbareProducten
            // 
            this.bsBeschikbareProducten.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsBeschikbareProducten_ListChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 1055);
            this.Controls.Add(this.btnBeheer);
            this.Controls.Add(this.lblOrderProducten);
            this.Controls.Add(this.txtGeselecteerdProductNaam);
            this.Controls.Add(this.lblProductCategorieen);
            this.Controls.Add(this.dgProductCategorieen);
            this.Controls.Add(this.txtOrderTotaalPrijs);
            this.Controls.Add(this.txtGeselecteerdProductTotaalPrijs);
            this.Controls.Add(this.txtGeselecteerdProductStuksprijs);
            this.Controls.Add(this.btnAfronden);
            this.Controls.Add(this.dgProductenInOrder);
            this.Controls.Add(this.btnVerwijderGeselecteerdProduct);
            this.Controls.Add(this.btnAddGeselecteerdProduct);
            this.Controls.Add(this.txtGeselecteerdProductAantal);
            this.Controls.Add(this.lblBeschikbareProducten);
            this.Controls.Add(this.dgBeschikbareProducten);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBeschikbareProducten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductenInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductCategorieen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductenInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCategorieen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBeschikbareProducten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBeschikbareProducten;
        private System.Windows.Forms.Label lblBeschikbareProducten;
        private System.Windows.Forms.TextBox txtGeselecteerdProductAantal;
        private System.Windows.Forms.Button btnAddGeselecteerdProduct;
        private System.Windows.Forms.Button btnVerwijderGeselecteerdProduct;
        private System.Windows.Forms.DataGridView dgProductenInOrder;
        private System.Windows.Forms.Button btnAfronden;
        private System.Windows.Forms.TextBox txtGeselecteerdProductStuksprijs;
        private System.Windows.Forms.TextBox txtGeselecteerdProductTotaalPrijs;
        private System.Windows.Forms.TextBox txtOrderTotaalPrijs;
        private System.Windows.Forms.DataGridView dgProductCategorieen;
        private System.Windows.Forms.Label lblProductCategorieen;
        private System.Windows.Forms.BindingSource bsProductenInOrder;
        private System.Windows.Forms.TextBox txtGeselecteerdProductNaam;
        private System.Windows.Forms.Label lblOrderProducten;
        private System.Windows.Forms.Button btnBeheer;
        private System.Windows.Forms.BindingSource bsProductCategorieen;
        private System.Windows.Forms.BindingSource bsBeschikbareProducten;
    }
}