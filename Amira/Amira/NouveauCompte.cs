using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Amira
{

    public partial class NouveauCompte : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost;Initial Catalog=db_authentification; uid=root;pwd='';");



        public NouveauCompte()
        {
            InitializeComponent();
        }
        



       

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            


            if (textBoxPrenom.Text == "" || comboBoxFonction.Text == "" || textBoxEmail.Text == "" || textBoxPwd.Text == "" || textBoxConfirmation.Text == "" || textBoxDateNaissance.Text == "" || textBoxNom.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
           

            else
            {
                if (textBoxPwd.Text != textBoxConfirmation.Text)
                {
                    MessageBox.Show("Les mots de passe saisies ne sont pas les mêmes");
                }
                else
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //define the command text
                    cmd.CommandText = "insert into utilisateurs (Prenom,Nom,Fonction,Date_De_Naissance,Email,Mot_de_passe,Confirmation) values ('" + textBoxPrenom.Text + "','" + textBoxNom.Text + "','" + comboBoxFonction.Text + "','" + textBoxDateNaissance.Text + "','" + textBoxEmail.Text + "','" + textBoxPwd.Text + "','" + textBoxConfirmation.Text + "');";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Compte crée avec succés ! ");
                    UseWaitCursor = true;
                    conn.Close();


                    this.Hide();
                    Form1 fm = new Form1();
                    UseWaitCursor = false;
                    fm.Show();
                }
            }
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
