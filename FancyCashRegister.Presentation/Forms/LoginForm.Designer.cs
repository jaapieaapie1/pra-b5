
namespace FancyCashRegister.Forms
{
    partial class LoginForm
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
            this.lbGebruikers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPincode = new System.Windows.Forms.MaskedTextBox();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGebruikers
            // 
            this.lbGebruikers.FormattingEnabled = true;
            this.lbGebruikers.ItemHeight = 15;
            this.lbGebruikers.Location = new System.Drawing.Point(18, 36);
            this.lbGebruikers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGebruikers.Name = "lbGebruikers";
            this.lbGebruikers.Size = new System.Drawing.Size(321, 574);
            this.lbGebruikers.TabIndex = 0;
            this.lbGebruikers.SelectedIndexChanged += new System.EventHandler(this.lbGebruikers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gebruikers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pincode";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(566, 36);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 98);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Inloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPincode
            // 
            this.txtPincode.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPincode.Location = new System.Drawing.Point(344, 36);
            this.txtPincode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPincode.Mask = "00000";
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.PasswordChar = '*';
            this.txtPincode.Size = new System.Drawing.Size(215, 78);
            this.txtPincode.TabIndex = 5;
            this.txtPincode.ValidatingType = typeof(int);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(709, 36);
            this.btnAfsluiten.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(135, 98);
            this.btnAfsluiten.TabIndex = 6;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 651);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGebruikers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGebruikers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox txtPincode;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

