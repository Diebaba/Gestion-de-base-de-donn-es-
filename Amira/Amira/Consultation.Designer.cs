using System;

namespace Amira
{
    partial class Consultation
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
            this.textBoxPrenomPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomPatient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDiagnostic = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxConsultation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrenomPatient
            // 
            this.textBoxPrenomPatient.Location = new System.Drawing.Point(402, 187);
            this.textBoxPrenomPatient.Name = "textBoxPrenomPatient";
            this.textBoxPrenomPatient.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrenomPatient.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom patient";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNomPatient
            // 
            this.textBoxNomPatient.Location = new System.Drawing.Point(402, 141);
            this.textBoxNomPatient.Name = "textBoxNomPatient";
            this.textBoxNomPatient.Size = new System.Drawing.Size(165, 20);
            this.textBoxNomPatient.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(256, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prenom patient";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(256, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(402, 241);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(165, 20);
            this.textBoxAge.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(256, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Diagnostic";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(876, 66);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consultation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.pictureBox1.Image = global::Amira.Properties.Resources.Asset_14;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(256, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Consultant";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDiagnostic
            // 
            this.textBoxDiagnostic.Location = new System.Drawing.Point(402, 328);
            this.textBoxDiagnostic.Multiline = true;
            this.textBoxDiagnostic.Name = "textBoxDiagnostic";
            this.textBoxDiagnostic.Size = new System.Drawing.Size(165, 42);
            this.textBoxDiagnostic.TabIndex = 15;
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.buttonValider.Location = new System.Drawing.Point(363, 386);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 17;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.button3.Location = new System.Drawing.Point(317, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Liste des consultations";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // comboBoxConsultation
            // 
            this.comboBoxConsultation.FormattingEnabled = true;
            this.comboBoxConsultation.Items.AddRange(new object[] {
            "Madame Touré",
            "M Boubacar Sow"});
            this.comboBoxConsultation.Location = new System.Drawing.Point(402, 284);
            this.comboBoxConsultation.Name = "comboBoxConsultation";
            this.comboBoxConsultation.Size = new System.Drawing.Size(165, 21);
            this.comboBoxConsultation.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(253)))));
            this.button1.Location = new System.Drawing.Point(771, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(584, 89);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(165, 20);
            this.textBoxRechercher.TabIndex = 25;
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::Amira.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxConsultation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxDiagnostic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrenomPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomPatient);
            this.Controls.Add(this.label4);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPrenomPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDiagnostic;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxConsultation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRechercher;
    }
}