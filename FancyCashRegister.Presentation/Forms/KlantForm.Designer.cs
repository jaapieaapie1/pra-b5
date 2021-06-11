
namespace FancyCashRegister.Forms
{
    partial class KlantForm
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
            this.dgProductenInOrder = new System.Windows.Forms.DataGridView();
            this.pbAdvertentie01 = new System.Windows.Forms.PictureBox();
            this.bsProductenInOrder = new System.Windows.Forms.BindingSource(this.components);
            this.txtTeBetalen = new System.Windows.Forms.TextBox();
            this.lblTeBetalen = new System.Windows.Forms.Label();
            this.lblOntvangen = new System.Windows.Forms.Label();
            this.txtOntvangen = new System.Windows.Forms.TextBox();
            this.lblTeruggave = new System.Windows.Forms.Label();
            this.txtTeruggave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductenInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvertentie01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductenInOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductenInOrder
            // 
            this.dgProductenInOrder.AllowUserToAddRows = false;
            this.dgProductenInOrder.AllowUserToDeleteRows = false;
            this.dgProductenInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductenInOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProductenInOrder.Location = new System.Drawing.Point(14, 13);
            this.dgProductenInOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgProductenInOrder.Name = "dgProductenInOrder";
            this.dgProductenInOrder.ReadOnly = true;
            this.dgProductenInOrder.RowHeadersVisible = false;
            this.dgProductenInOrder.RowHeadersWidth = 51;
            this.dgProductenInOrder.RowTemplate.Height = 50;
            this.dgProductenInOrder.RowTemplate.ReadOnly = true;
            this.dgProductenInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductenInOrder.Size = new System.Drawing.Size(608, 756);
            this.dgProductenInOrder.TabIndex = 7;
            this.dgProductenInOrder.DataSourceChanged += new System.EventHandler(this.dgProductenInOrder_DataSourceChanged);
            this.dgProductenInOrder.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgProductenInOrder_ColumnAdded);
            this.dgProductenInOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgProductenInOrder_RowsAdded);
            // 
            // pbAdvertentie01
            // 
            this.pbAdvertentie01.Location = new System.Drawing.Point(630, 13);
            this.pbAdvertentie01.Name = "pbAdvertentie01";
            this.pbAdvertentie01.Size = new System.Drawing.Size(440, 260);
            this.pbAdvertentie01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdvertentie01.TabIndex = 8;
            this.pbAdvertentie01.TabStop = false;
            // 
            // bsProductenInOrder
            // 
            this.bsProductenInOrder.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsProductenInOrder_ListChanged);
            // 
            // txtTeBetalen
            // 
            this.txtTeBetalen.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeBetalen.Location = new System.Drawing.Point(888, 280);
            this.txtTeBetalen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeBetalen.Name = "txtTeBetalen";
            this.txtTeBetalen.ReadOnly = true;
            this.txtTeBetalen.Size = new System.Drawing.Size(181, 74);
            this.txtTeBetalen.TabIndex = 11;
            this.txtTeBetalen.Text = "0,00";
            this.txtTeBetalen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTeBetalen
            // 
            this.lblTeBetalen.AutoSize = true;
            this.lblTeBetalen.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeBetalen.Location = new System.Drawing.Point(630, 276);
            this.lblTeBetalen.Name = "lblTeBetalen";
            this.lblTeBetalen.Size = new System.Drawing.Size(253, 67);
            this.lblTeBetalen.TabIndex = 12;
            this.lblTeBetalen.Text = "Te betalen";
            // 
            // lblOntvangen
            // 
            this.lblOntvangen.AutoSize = true;
            this.lblOntvangen.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOntvangen.Location = new System.Drawing.Point(630, 373);
            this.lblOntvangen.Name = "lblOntvangen";
            this.lblOntvangen.Size = new System.Drawing.Size(272, 67);
            this.lblOntvangen.TabIndex = 13;
            this.lblOntvangen.Text = "Ontvangen";
            // 
            // txtOntvangen
            // 
            this.txtOntvangen.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOntvangen.Location = new System.Drawing.Point(888, 369);
            this.txtOntvangen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOntvangen.Name = "txtOntvangen";
            this.txtOntvangen.ReadOnly = true;
            this.txtOntvangen.Size = new System.Drawing.Size(181, 74);
            this.txtOntvangen.TabIndex = 14;
            this.txtOntvangen.Text = "0,00";
            this.txtOntvangen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTeruggave
            // 
            this.lblTeruggave.AutoSize = true;
            this.lblTeruggave.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeruggave.Location = new System.Drawing.Point(630, 463);
            this.lblTeruggave.Name = "lblTeruggave";
            this.lblTeruggave.Size = new System.Drawing.Size(254, 67);
            this.lblTeruggave.TabIndex = 15;
            this.lblTeruggave.Text = "Teruggave";
            // 
            // txtTeruggave
            // 
            this.txtTeruggave.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTeruggave.Location = new System.Drawing.Point(888, 459);
            this.txtTeruggave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeruggave.Name = "txtTeruggave";
            this.txtTeruggave.ReadOnly = true;
            this.txtTeruggave.Size = new System.Drawing.Size(181, 74);
            this.txtTeruggave.TabIndex = 16;
            this.txtTeruggave.Text = "0,00";
            this.txtTeruggave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 784);
            this.Controls.Add(this.txtTeruggave);
            this.Controls.Add(this.lblTeruggave);
            this.Controls.Add(this.txtOntvangen);
            this.Controls.Add(this.lblOntvangen);
            this.Controls.Add(this.lblTeBetalen);
            this.Controls.Add(this.txtTeBetalen);
            this.Controls.Add(this.pbAdvertentie01);
            this.Controls.Add(this.dgProductenInOrder);
            this.Name = "KlantForm";
            this.Text = "KlantForm";
            this.Load += new System.EventHandler(this.KlantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductenInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvertentie01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductenInOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductenInOrder;
        private System.Windows.Forms.PictureBox pbAdvertentie01;
        private System.Windows.Forms.BindingSource bsProductenInOrder;
        private System.Windows.Forms.TextBox txtTeBetalen;
        private System.Windows.Forms.Label lblTeBetalen;
        private System.Windows.Forms.Label lblOntvangen;
        private System.Windows.Forms.TextBox txtOntvangen;
        private System.Windows.Forms.Label lblTeruggave;
        private System.Windows.Forms.TextBox txtTeruggave;
    }
}