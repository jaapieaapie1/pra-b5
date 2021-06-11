
namespace FancyCashRegister.Forms
{
    partial class BetalenForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTeBetalen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOntvangen = new System.Windows.Forms.TextBox();
            this.txtTeruggave = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lbTeruggave = new System.Windows.Forms.ListBox();
            this.dgProductenInOrder = new System.Windows.Forms.DataGridView();
            this.colOrderProductNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductStuksprijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductAantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductTotaalPrijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductBeschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAfgerond = new System.Windows.Forms.Button();
            this.lblTeBetalen = new System.Windows.Forms.Label();
            this.lblOntvangen = new System.Windows.Forms.Label();
            this.lblTeruggave = new System.Windows.Forms.Label();
            this.gbBetaling = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBeschikbareActieCodes = new System.Windows.Forms.ListBox();
            this.txtKortingsCode = new System.Windows.Forms.TextBox();
            this.lblKortingsCode = new System.Windows.Forms.Label();
            this.btnActiveerKortingsCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductenInOrder)).BeginInit();
            this.gbBetaling.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeBetalen
            // 
            this.txtTeBetalen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeBetalen.Location = new System.Drawing.Point(77, 16);
            this.txtTeBetalen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTeBetalen.Name = "txtTeBetalen";
            this.txtTeBetalen.Size = new System.Drawing.Size(116, 43);
            this.txtTeBetalen.TabIndex = 1;
            this.txtTeBetalen.TextChanged += new System.EventHandler(this.txtTeBetalen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtOntvangen
            // 
            this.txtOntvangen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOntvangen.Location = new System.Drawing.Point(77, 65);
            this.txtOntvangen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOntvangen.Name = "txtOntvangen";
            this.txtOntvangen.Size = new System.Drawing.Size(116, 43);
            this.txtOntvangen.TabIndex = 3;
            this.txtOntvangen.Click += new System.EventHandler(this.txtOntvangen_Click);
            this.txtOntvangen.TextChanged += new System.EventHandler(this.txtOntvangen_TextChanged);
            // 
            // txtTeruggave
            // 
            this.txtTeruggave.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeruggave.Location = new System.Drawing.Point(77, 114);
            this.txtTeruggave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTeruggave.Name = "txtTeruggave";
            this.txtTeruggave.Size = new System.Drawing.Size(116, 43);
            this.txtTeruggave.TabIndex = 4;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(523, 528);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(79, 51);
            this.btnTerug.TabIndex = 5;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lbTeruggave
            // 
            this.lbTeruggave.FormattingEnabled = true;
            this.lbTeruggave.ItemHeight = 15;
            this.lbTeruggave.Location = new System.Drawing.Point(738, 26);
            this.lbTeruggave.Name = "lbTeruggave";
            this.lbTeruggave.Size = new System.Drawing.Size(120, 94);
            this.lbTeruggave.TabIndex = 6;
            // 
            // dgProductenInOrder
            // 
            this.dgProductenInOrder.AllowUserToAddRows = false;
            this.dgProductenInOrder.AllowUserToDeleteRows = false;
            this.dgProductenInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductenInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderProductNaam,
            this.colOrderProductStuksprijs,
            this.colOrderProductAantal,
            this.colOrderProductTotaalPrijs,
            this.colOrderProductProductId,
            this.colOrderProductCategoryId,
            this.colOrderProductBeschrijving});
            this.dgProductenInOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProductenInOrder.Location = new System.Drawing.Point(13, 12);
            this.dgProductenInOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgProductenInOrder.MultiSelect = false;
            this.dgProductenInOrder.Name = "dgProductenInOrder";
            this.dgProductenInOrder.ReadOnly = true;
            this.dgProductenInOrder.RowHeadersVisible = false;
            this.dgProductenInOrder.RowHeadersWidth = 51;
            this.dgProductenInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductenInOrder.Size = new System.Drawing.Size(503, 483);
            this.dgProductenInOrder.TabIndex = 7;
            this.dgProductenInOrder.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgProductenInOrder_ColumnAdded);
            this.dgProductenInOrder.SelectionChanged += new System.EventHandler(this.dgProductenInOrder_SelectionChanged);
            // 
            // colOrderProductNaam
            // 
            this.colOrderProductNaam.DataPropertyName = "Naam";
            this.colOrderProductNaam.HeaderText = "Naam";
            this.colOrderProductNaam.MinimumWidth = 6;
            this.colOrderProductNaam.Name = "colOrderProductNaam";
            this.colOrderProductNaam.ReadOnly = true;
            this.colOrderProductNaam.Width = 125;
            // 
            // colOrderProductStuksprijs
            // 
            this.colOrderProductStuksprijs.DataPropertyName = "Stuksprijs";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOrderProductStuksprijs.DefaultCellStyle = dataGridViewCellStyle7;
            this.colOrderProductStuksprijs.HeaderText = "Stuksprijs";
            this.colOrderProductStuksprijs.MinimumWidth = 6;
            this.colOrderProductStuksprijs.Name = "colOrderProductStuksprijs";
            this.colOrderProductStuksprijs.ReadOnly = true;
            this.colOrderProductStuksprijs.Width = 125;
            // 
            // colOrderProductAantal
            // 
            this.colOrderProductAantal.DataPropertyName = "Aantal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colOrderProductAantal.DefaultCellStyle = dataGridViewCellStyle8;
            this.colOrderProductAantal.HeaderText = "Aantal";
            this.colOrderProductAantal.MinimumWidth = 6;
            this.colOrderProductAantal.Name = "colOrderProductAantal";
            this.colOrderProductAantal.ReadOnly = true;
            this.colOrderProductAantal.Width = 125;
            // 
            // colOrderProductTotaalPrijs
            // 
            this.colOrderProductTotaalPrijs.DataPropertyName = "TotaalPrijs";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOrderProductTotaalPrijs.DefaultCellStyle = dataGridViewCellStyle9;
            this.colOrderProductTotaalPrijs.HeaderText = "Totaal";
            this.colOrderProductTotaalPrijs.MinimumWidth = 6;
            this.colOrderProductTotaalPrijs.Name = "colOrderProductTotaalPrijs";
            this.colOrderProductTotaalPrijs.ReadOnly = true;
            this.colOrderProductTotaalPrijs.Width = 125;
            // 
            // colOrderProductProductId
            // 
            this.colOrderProductProductId.DataPropertyName = "Id";
            this.colOrderProductProductId.HeaderText = "Product ID";
            this.colOrderProductProductId.MinimumWidth = 6;
            this.colOrderProductProductId.Name = "colOrderProductProductId";
            this.colOrderProductProductId.ReadOnly = true;
            this.colOrderProductProductId.Visible = false;
            this.colOrderProductProductId.Width = 125;
            // 
            // colOrderProductCategoryId
            // 
            this.colOrderProductCategoryId.DataPropertyName = "CategorieId";
            this.colOrderProductCategoryId.HeaderText = "Categorie Id";
            this.colOrderProductCategoryId.MinimumWidth = 6;
            this.colOrderProductCategoryId.Name = "colOrderProductCategoryId";
            this.colOrderProductCategoryId.ReadOnly = true;
            this.colOrderProductCategoryId.Visible = false;
            this.colOrderProductCategoryId.Width = 125;
            // 
            // colOrderProductBeschrijving
            // 
            this.colOrderProductBeschrijving.DataPropertyName = "Beschrijving";
            this.colOrderProductBeschrijving.HeaderText = "Beschrijving";
            this.colOrderProductBeschrijving.MinimumWidth = 6;
            this.colOrderProductBeschrijving.Name = "colOrderProductBeschrijving";
            this.colOrderProductBeschrijving.ReadOnly = true;
            this.colOrderProductBeschrijving.Visible = false;
            this.colOrderProductBeschrijving.Width = 125;
            // 
            // btnAfgerond
            // 
            this.btnAfgerond.Location = new System.Drawing.Point(610, 528);
            this.btnAfgerond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAfgerond.Name = "btnAfgerond";
            this.btnAfgerond.Size = new System.Drawing.Size(79, 51);
            this.btnAfgerond.TabIndex = 8;
            this.btnAfgerond.Text = "Betaald";
            this.btnAfgerond.UseVisualStyleBackColor = true;
            this.btnAfgerond.Click += new System.EventHandler(this.btnAfgerond_Click);
            // 
            // lblTeBetalen
            // 
            this.lblTeBetalen.AutoSize = true;
            this.lblTeBetalen.Location = new System.Drawing.Point(6, 37);
            this.lblTeBetalen.Name = "lblTeBetalen";
            this.lblTeBetalen.Size = new System.Drawing.Size(38, 15);
            this.lblTeBetalen.TabIndex = 9;
            this.lblTeBetalen.Text = "Totaal";
            // 
            // lblOntvangen
            // 
            this.lblOntvangen.AutoSize = true;
            this.lblOntvangen.Location = new System.Drawing.Point(6, 86);
            this.lblOntvangen.Name = "lblOntvangen";
            this.lblOntvangen.Size = new System.Drawing.Size(66, 15);
            this.lblOntvangen.TabIndex = 10;
            this.lblOntvangen.Text = "Ontvangen";
            // 
            // lblTeruggave
            // 
            this.lblTeruggave.AutoSize = true;
            this.lblTeruggave.Location = new System.Drawing.Point(6, 135);
            this.lblTeruggave.Name = "lblTeruggave";
            this.lblTeruggave.Size = new System.Drawing.Size(61, 15);
            this.lblTeruggave.TabIndex = 11;
            this.lblTeruggave.Text = "Teruggave";
            // 
            // gbBetaling
            // 
            this.gbBetaling.Controls.Add(this.txtTeruggave);
            this.gbBetaling.Controls.Add(this.lblTeruggave);
            this.gbBetaling.Controls.Add(this.txtTeBetalen);
            this.gbBetaling.Controls.Add(this.lblOntvangen);
            this.gbBetaling.Controls.Add(this.txtOntvangen);
            this.gbBetaling.Controls.Add(this.lblTeBetalen);
            this.gbBetaling.Location = new System.Drawing.Point(523, 14);
            this.gbBetaling.Name = "gbBetaling";
            this.gbBetaling.Size = new System.Drawing.Size(209, 178);
            this.gbBetaling.TabIndex = 12;
            this.gbBetaling.TabStop = false;
            this.gbBetaling.Text = "Betaling";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActiveerKortingsCode);
            this.groupBox1.Controls.Add(this.txtKortingsCode);
            this.groupBox1.Controls.Add(this.lblKortingsCode);
            this.groupBox1.Controls.Add(this.lbBeschikbareActieCodes);
            this.groupBox1.Location = new System.Drawing.Point(523, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 296);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kortingen && Acties";
            // 
            // lbBeschikbareActieCodes
            // 
            this.lbBeschikbareActieCodes.FormattingEnabled = true;
            this.lbBeschikbareActieCodes.ItemHeight = 15;
            this.lbBeschikbareActieCodes.Location = new System.Drawing.Point(6, 22);
            this.lbBeschikbareActieCodes.Name = "lbBeschikbareActieCodes";
            this.lbBeschikbareActieCodes.Size = new System.Drawing.Size(120, 94);
            this.lbBeschikbareActieCodes.TabIndex = 14;
            // 
            // txtKortingsCode
            // 
            this.txtKortingsCode.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKortingsCode.Location = new System.Drawing.Point(146, 157);
            this.txtKortingsCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKortingsCode.Name = "txtKortingsCode";
            this.txtKortingsCode.Size = new System.Drawing.Size(116, 43);
            this.txtKortingsCode.TabIndex = 12;
            this.txtKortingsCode.Click += new System.EventHandler(this.txtKortingsCode_Click);
            // 
            // lblKortingsCode
            // 
            this.lblKortingsCode.AutoSize = true;
            this.lblKortingsCode.Location = new System.Drawing.Point(6, 185);
            this.lblKortingsCode.Name = "lblKortingsCode";
            this.lblKortingsCode.Size = new System.Drawing.Size(77, 15);
            this.lblKortingsCode.TabIndex = 13;
            this.lblKortingsCode.Text = "Kortingscode";
            // 
            // btnActiveerKortingsCode
            // 
            this.btnActiveerKortingsCode.Location = new System.Drawing.Point(269, 157);
            this.btnActiveerKortingsCode.Name = "btnActiveerKortingsCode";
            this.btnActiveerKortingsCode.Size = new System.Drawing.Size(75, 43);
            this.btnActiveerKortingsCode.TabIndex = 15;
            this.btnActiveerKortingsCode.Text = "Activeer";
            this.btnActiveerKortingsCode.UseVisualStyleBackColor = true;
            this.btnActiveerKortingsCode.Click += new System.EventHandler(this.btnActiveerKortingsCode_Click);
            // 
            // BetalenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBetaling);
            this.Controls.Add(this.btnAfgerond);
            this.Controls.Add(this.dgProductenInOrder);
            this.Controls.Add(this.lbTeruggave);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BetalenForm";
            this.Text = "BetalenForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BetalenForm_FormClosed);
            this.Load += new System.EventHandler(this.BetalenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductenInOrder)).EndInit();
            this.gbBetaling.ResumeLayout(false);
            this.gbBetaling.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTeBetalen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOntvangen;
        private System.Windows.Forms.TextBox txtTeruggave;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbTeruggave;
        private System.Windows.Forms.DataGridView dgProductenInOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductNaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductStuksprijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductAantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductTotaalPrijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductBeschrijving;
        private System.Windows.Forms.Button btnAfgerond;
        private System.Windows.Forms.Label lblTeBetalen;
        private System.Windows.Forms.Label lblOntvangen;
        private System.Windows.Forms.Label lblTeruggave;
        private System.Windows.Forms.GroupBox gbBetaling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKortingsCode;
        private System.Windows.Forms.Label lblKortingsCode;
        private System.Windows.Forms.ListBox lbBeschikbareActieCodes;
        private System.Windows.Forms.Button btnActiveerKortingsCode;
    }
}