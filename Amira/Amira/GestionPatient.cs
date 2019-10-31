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

namespace Amira
{
    public partial class GestionPatient : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';");
        public GestionPatient()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil fm = new Accueil();
            fm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {


            if (textBoxNomPatient.Text == "" || textBoxPrenomPatient.Text == "" || textBoxAdresse.Text == "" || textBoxDateNaisse.Text == "" || textBoxTelephone.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {


                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //define the command text
                cmd.CommandText = "insert into  patients (Nom,Prenom,Date_de_Naissance,Adresse,Telephone) values ('" + textBoxNomPatient.Text + "','" + textBoxPrenomPatient.Text + "','" + textBoxDateNaisse.Text + "','" + textBoxAdresse.Text + "','" + textBoxTelephone.Text + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion effectué avec succés ! ");
                conn.Close();
                this.Hide();
                GestionPatient fm = new GestionPatient();
                fm.Show();


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListePatients fm = new ListePatients();
            fm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=gestion-poste-de-santé;uid=root;pwd='';";
            con = new MySqlConnection(connetionString);
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            msqlCommand.Connection = con;
            msqlCommand.CommandText = "SELECT Nom,Prenom,Date_de_Naissance,Adresse,Telephone FROM Patients WHERE Numero='" + textBoxRechercher.Text + "'";
            con.Open();
            MySqlDataReader dr = msqlCommand.ExecuteReader();



            /*string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT * FROM Consultation WHERE Numero='" + textBoxRechercher.Text + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();*/

            if (textBoxRechercher.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro de dossier du patient que vous désirer retrouver ");
            }
            else
            {
                while (dr.Read())
                {
                    textBoxNomPatient.Text = dr["Nom"].ToString();
                    textBoxPrenomPatient.Text = dr["Prenom"].ToString();
                    textBoxDateNaisse.Text = dr["Date_de_Naissance"].ToString();
                    textBoxAdresse.Text = dr["Adresse"].ToString();
                    textBoxTelephone.Text = dr["Telephone"].ToString();
                }
            }
            con.Close();

        }
    }
}
