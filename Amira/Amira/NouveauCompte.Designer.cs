namespace Amira
{
    partial class NouveauCompte
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxConfirmation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxFonction = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(876, 66);
            this.label2.TabIndex = 13;
            this.label2.Text = "Creer un compte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.buttonValider.Location = new System.Drawing.Point(428, 354);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(202, 23);
            this.buttonValider.TabIndex = 33;
            this.buttonValider.Text = "Creer un compte";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(515, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(160, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date de naissance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDateNaissance
            // 
            this.textBoxDateNaissance.Location = new System.Drawing.Point(306, 155);
            this.textBoxDateNaissance.Name = "textBoxDateNaissance";
            this.textBoxDateNaissance.Size = new System.Drawing.Size(165, 20);
            this.textBoxDateNaissance.TabIndex = 29;
            this.textBoxDateNaissance.Text = "AAAA/MM/JJ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(515, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mot de passe";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(661, 92);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(165, 20);
            this.textBoxNom.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(160, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prenom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(306, 93);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrenom.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(515, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nom";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(661, 158);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(165, 20);
            this.textBoxEmail.TabIndex = 34;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(661, 230);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(165, 20);
            this.textBoxPwd.TabIndex = 35;
            // 
            // textBoxConfirmation
            // 
            this.textBoxConfirmation.Location = new System.Drawing.Point(305, 288);
            this.textBoxConfirmation.Name = "textBoxConfirmation";
            this.textBoxConfirmation.Size = new System.Drawing.Size(165, 20);
            this.textBoxConfirmation.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Confirmation du mot de passe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(160, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fonction";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFonction
            // 
            this.comboBoxFonction.FormattingEnabled = true;
            this.comboBoxFonction.Items.AddRange(new object[] {
            "Infirmier Chef de Poste",
            "Sage-Femme",
            "Infirmier",
            "Infirmière",
            "Matronne"});
            this.comboBoxFonction.Location = new System.Drawing.Point(306, 224);
            this.comboBoxFonction.Name = "comboBoxFonction";
            this.comboBoxFonction.Size = new System.Drawing.Size(165, 21);
            this.comboBoxFonction.TabIndex = 39;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.button5.Location = new System.Drawing.Point(11, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "Retour";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // NouveauCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBoxFonction);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxConfirmation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDateNaissance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "NouveauCompte";
            this.Text = "NouveauCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateNaissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxConfirmation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxFonction;
        private System.Windows.Forms.Button button5;
    }
}