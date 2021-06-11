
namespace FancyCashRegister.Forms
{
    partial class BeheerForm
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnAfmelden = new System.Windows.Forms.Button();
            this.tcBeheerTabs = new System.Windows.Forms.TabControl();
            this.tabBeheerGebruikers = new System.Windows.Forms.TabPage();
            this.tabBeheerProducten = new System.Windows.Forms.TabPage();
            this.tabBeheerApplicatie = new System.Windows.Forms.TabPage();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.lbRollen = new System.Windows.Forms.ListBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.chkKanInloggen = new System.Windows.Forms.CheckBox();
            this.lblVolledigenaam = new System.Windows.Forms.Label();
            this.txtVolledigeNaam = new System.Windows.Forms.TextBox();
            this.txtPincode = new System.Windows.Forms.MaskedTextBox();
            this.lblPincode = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtGebruikerId = new System.Windows.Forms.TextBox();
            this.lblGebruikerId = new System.Windows.Forms.Label();
            this.lbGebruikers = new System.Windows.Forms.ListBox();
            this.tcBeheerTabs.SuspendLayout();
            this.tabBeheerGebruikers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(12, 153);
            this.btnAfsluiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(118, 68);
            this.btnAfsluiten.TabIndex = 0;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(10, 9);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(118, 68);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnAfmelden
            // 
            this.btnAfmelden.Location = new System.Drawing.Point(12, 81);
            this.btnAfmelden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfmelden.Name = "btnAfmelden";
            this.btnAfmelden.Size = new System.Drawing.Size(118, 68);
            this.btnAfmelden.TabIndex = 13;
            this.btnAfmelden.Text = "Afmelden";
            this.btnAfmelden.UseVisualStyleBackColor = true;
            this.btnAfmelden.Click += new System.EventHandler(this.btnAfmelden_Click);
            // 
            // tcBeheerTabs
            // 
            this.tcBeheerTabs.Controls.Add(this.tabBeheerGebruikers);
            this.tcBeheerTabs.Controls.Add(this.tabBeheerProducten);
            this.tcBeheerTabs.Controls.Add(this.tabBeheerApplicatie);
            this.tcBeheerTabs.Enabled = false;
            this.tcBeheerTabs.Location = new System.Drawing.Point(136, 12);
            this.tcBeheerTabs.Name = "tcBeheerTabs";
            this.tcBeheerTabs.SelectedIndex = 0;
            this.tcBeheerTabs.Size = new System.Drawing.Size(731, 418);
            this.tcBeheerTabs.TabIndex = 14;
            // 
            // tabBeheerGebruikers
            // 
            this.tabBeheerGebruikers.Controls.Add(this.btnOpslaan);
            this.tabBeheerGebruikers.Controls.Add(this.lblRol);
            this.tabBeheerGebruikers.Controls.Add(this.lbRollen);
            this.tabBeheerGebruikers.Controls.Add(this.lbGebruikers);
            this.tabBeheerGebruikers.Controls.Add(this.lblGebruikerId);
            this.tabBeheerGebruikers.Controls.Add(this.chkKanInloggen);
            this.tabBeheerGebruikers.Controls.Add(this.txtPincode);
            this.tabBeheerGebruikers.Controls.Add(this.txtGebruikerId);
            this.tabBeheerGebruikers.Controls.Add(this.txtVolledigeNaam);
            this.tabBeheerGebruikers.Controls.Add(this.lblGebruikersnaam);
            this.tabBeheerGebruikers.Controls.Add(this.lblVolledigenaam);
            this.tabBeheerGebruikers.Controls.Add(this.txtGebruikersnaam);
            this.tabBeheerGebruikers.Controls.Add(this.lblPincode);
            this.tabBeheerGebruikers.Location = new System.Drawing.Point(4, 24);
            this.tabBeheerGebruikers.Name = "tabBeheerGebruikers";
            this.tabBeheerGebruikers.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeheerGebruikers.Size = new System.Drawing.Size(723, 390);
            this.tabBeheerGebruikers.TabIndex = 0;
            this.tabBeheerGebruikers.Text = "Gebruikers";
            this.tabBeheerGebruikers.UseVisualStyleBackColor = true;
            // 
            // tabBeheerProducten
            // 
            this.tabBeheerProducten.Location = new System.Drawing.Point(4, 24);
            this.tabBeheerProducten.Name = "tabBeheerProducten";
            this.tabBeheerProducten.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeheerProducten.Size = new System.Drawing.Size(723, 390);
            this.tabBeheerProducten.TabIndex = 1;
            this.tabBeheerProducten.Text = "Producten";
            this.tabBeheerProducten.UseVisualStyleBackColor = true;
            // 
            // tabBeheerApplicatie
            // 
            this.tabBeheerApplicatie.Location = new System.Drawing.Point(4, 24);
            this.tabBeheerApplicatie.Name = "tabBeheerApplicatie";
            this.tabBeheerApplicatie.Size = new System.Drawing.Size(723, 390);
            this.tabBeheerApplicatie.TabIndex = 2;
            this.tabBeheerApplicatie.Text = "Applicatie";
            this.tabBeheerApplicatie.UseVisualStyleBackColor = true;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(432, 241);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(118, 78);
            this.btnOpslaan.TabIndex = 5;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // lbRollen
            // 
            this.lbRollen.FormattingEnabled = true;
            this.lbRollen.ItemHeight = 15;
            this.lbRollen.Location = new System.Drawing.Point(250, 240);
            this.lbRollen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRollen.Name = "lbRollen";
            this.lbRollen.Size = new System.Drawing.Size(176, 79);
            this.lbRollen.TabIndex = 15;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(145, 256);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 14;
            this.lblRol.Text = "Rol";
            // 
            // chkKanInloggen
            // 
            this.chkKanInloggen.AutoSize = true;
            this.chkKanInloggen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKanInloggen.Location = new System.Drawing.Point(171, 217);
            this.chkKanInloggen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkKanInloggen.Name = "chkKanInloggen";
            this.chkKanInloggen.Size = new System.Drawing.Size(96, 19);
            this.chkKanInloggen.TabIndex = 12;
            this.chkKanInloggen.Text = "Kan inloggen";
            this.chkKanInloggen.UseVisualStyleBackColor = true;
            // 
            // lblVolledigenaam
            // 
            this.lblVolledigenaam.AutoSize = true;
            this.lblVolledigenaam.Location = new System.Drawing.Point(145, 186);
            this.lblVolledigenaam.Name = "lblVolledigenaam";
            this.lblVolledigenaam.Size = new System.Drawing.Size(88, 15);
            this.lblVolledigenaam.TabIndex = 7;
            this.lblVolledigenaam.Text = "Volledige naam";
            // 
            // txtVolledigeNaam
            // 
            this.txtVolledigeNaam.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVolledigeNaam.Location = new System.Drawing.Point(250, 153);
            this.txtVolledigeNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVolledigeNaam.Name = "txtVolledigeNaam";
            this.txtVolledigeNaam.Size = new System.Drawing.Size(176, 43);
            this.txtVolledigeNaam.TabIndex = 10;
            // 
            // txtPincode
            // 
            this.txtPincode.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPincode.Location = new System.Drawing.Point(250, 106);
            this.txtPincode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPincode.Mask = "00000";
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.PasswordChar = '*';
            this.txtPincode.Size = new System.Drawing.Size(176, 43);
            this.txtPincode.TabIndex = 11;
            this.txtPincode.ValidatingType = typeof(int);
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.Location = new System.Drawing.Point(141, 130);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(50, 15);
            this.lblPincode.TabIndex = 7;
            this.lblPincode.Text = "Pincode";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(141, 69);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(92, 15);
            this.lblGebruikersnaam.TabIndex = 9;
            this.lblGebruikersnaam.Text = "gebruikersnaam";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGebruikersnaam.Location = new System.Drawing.Point(250, 59);
            this.txtGebruikersnaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(176, 43);
            this.txtGebruikersnaam.TabIndex = 8;
            // 
            // txtGebruikerId
            // 
            this.txtGebruikerId.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGebruikerId.Location = new System.Drawing.Point(250, 12);
            this.txtGebruikerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGebruikerId.Name = "txtGebruikerId";
            this.txtGebruikerId.ReadOnly = true;
            this.txtGebruikerId.Size = new System.Drawing.Size(176, 43);
            this.txtGebruikerId.TabIndex = 6;
            // 
            // lblGebruikerId
            // 
            this.lblGebruikerId.AutoSize = true;
            this.lblGebruikerId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGebruikerId.Location = new System.Drawing.Point(141, 12);
            this.lblGebruikerId.Name = "lblGebruikerId";
            this.lblGebruikerId.Size = new System.Drawing.Size(69, 15);
            this.lblGebruikerId.TabIndex = 4;
            this.lblGebruikerId.Text = "Database ID";
            // 
            // lbGebruikers
            // 
            this.lbGebruikers.FormattingEnabled = true;
            this.lbGebruikers.ItemHeight = 15;
            this.lbGebruikers.Location = new System.Drawing.Point(3, 12);
            this.lbGebruikers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbGebruikers.Name = "lbGebruikers";
            this.lbGebruikers.Size = new System.Drawing.Size(132, 259);
            this.lbGebruikers.TabIndex = 3;
            this.lbGebruikers.SelectedIndexChanged += new System.EventHandler(this.lbGebruikers_SelectedIndexChanged);
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 530);
            this.Controls.Add(this.tcBeheerTabs);
            this.Controls.Add(this.btnAfmelden);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAfsluiten);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BeheerForm";
            this.Text = "BeheerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeheerForm_FormClosed);
            this.Load += new System.EventHandler(this.BeheerForm_Load);
            this.tcBeheerTabs.ResumeLayout(false);
            this.tabBeheerGebruikers.ResumeLayout(false);
            this.tabBeheerGebruikers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnAfmelden;
        private System.Windows.Forms.TabControl tcBeheerTabs;
        private System.Windows.Forms.TabPage tabBeheerGebruikers;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ListBox lbRollen;
        private System.Windows.Forms.ListBox lbGebruikers;
        private System.Windows.Forms.Label lblGebruikerId;
        private System.Windows.Forms.CheckBox chkKanInloggen;
        private System.Windows.Forms.MaskedTextBox txtPincode;
        private System.Windows.Forms.TextBox txtGebruikerId;
        private System.Windows.Forms.TextBox txtVolledigeNaam;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Label lblVolledigenaam;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.TabPage tabBeheerProducten;
        private System.Windows.Forms.TabPage tabBeheerApplicatie;
    }
}