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

    public partial class GestionPersonnel : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';");

        public GestionPersonnel()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil fm = new Accueil();
            fm.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (textBoxPrenom.Text == "" || comboBoxFonction.Text == "" || textBoxEmail.Text == "" || textBoxDateNaisse.Text == "" || textBoxNom.Text == "" || textBoxAdresse.Text == "" || textBoxTelephone.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {
                System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (textBoxEmail.Text.Length > 0)
                {
                    if (!rEMail.IsMatch(textBoxEmail.Text))
                    {
                        MessageBox.Show("l'adresse e-mail n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmail.SelectAll();


                    }
                }

                conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //define the command text
                    cmd.CommandText = "insert into  personnel (Prenom,Nom,Fonction,Date_De_Naissance,Email,Telephone,Adresse) values ('" + textBoxPrenom.Text + "','" + textBoxNom.Text + "','" + comboBoxFonction.Text+ "','" + textBoxDateNaisse.Text + "','" + textBoxEmail.Text + "','" + textBoxTelephone.Text + "','" + textBoxAdresse.Text + "');";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion effectué avec succés ! ");
                    conn.Close();
                this.Hide();
                GestionPersonnel fm = new GestionPersonnel();
                fm.Show();



            }
        }

        private void TextBoxDateNaisse_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GestionPersonnel_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxFonction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListePersonnel fm = new ListePersonnel();
            fm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=gestion-poste-de-santé;uid=root;pwd='';";
            con = new MySqlConnection(connetionString);
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            msqlCommand.Connection = con;
            msqlCommand.CommandText = "SELECT Prenom,Nom,Date_de_Naissance,Adresse,Telephone,Email,Fonction FROM Personnel WHERE Numéro='" + textBoxRechercher.Text + "'";
            con.Open();
            MySqlDataReader dr = msqlCommand.ExecuteReader();



            /*string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT * FROM Consultation WHERE Numero='" + textBoxRechercher.Text + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();*/

            if (textBoxRechercher.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro de  que vous désirer retrouver ");
            }
            else
            {
                while (dr.Read())
                {
                    textBoxPrenom.Text = dr["Prenom"].ToString();
                    textBoxNom.Text = dr["Nom"].ToString();
                    textBoxDateNaisse.Text = dr["Date_de_Naissance"].ToString();
                    textBoxAdresse.Text = dr["Adresse"].ToString();
                    textBoxTelephone.Text = dr["Telephone"].ToString();
                    textBoxEmail.Text = dr["Email"].ToString();
                    comboBoxFonction.Text = dr["Fonction"].ToString();


                }
            }
            con.Close();
        }
    }

}
