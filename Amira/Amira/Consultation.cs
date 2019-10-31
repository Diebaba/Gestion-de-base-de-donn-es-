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
    public partial class Consultation : Form


    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';");
        
      

        public Consultation()
        {
            InitializeComponent();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            

            if ( textBoxNomPatient.Text == "" || textBoxPrenomPatient.Text == "" || textBoxAge.Text == "" || comboBoxConsultation.Text == "" || textBoxDiagnostic.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {
               conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //define the command text
                cmd.CommandText = "insert into  consultation (Diagnostic,Nom_Consultant,Nom_Patient,Prenom_Patient,Age) values ('" + textBoxNomPatient.Text + "','" + textBoxPrenomPatient.Text + "','" + textBoxAge.Text + "','" + comboBoxConsultation.Text + "','" + textBoxDiagnostic.Text + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion effectué avec succés ! ");
                this.Hide();
                Consultation fm = new Consultation();
                fm.Show();


                
                conn.Close();

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil fm = new Accueil();
            fm.Show();
        }

        private void TextBoxConsultant_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            

            
            this.Hide();
            ListeConsultation fm = new ListeConsultation();
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
            msqlCommand.CommandText = "SELECT Nom_Patient,Prenom_Patient,Age,Nom_Consultant,Diagnostic FROM Consultation WHERE Numero='" + textBoxRechercher.Text + "'";
            con.Open();
            MySqlDataReader dr = msqlCommand.ExecuteReader();
           


            /*string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT * FROM Consultation WHERE Numero='" + textBoxRechercher.Text + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();*/

            if (textBoxRechercher.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro de consulation que vous désirer retrouver ");
            }
                else
                {
                   while(dr.Read() )
                   {
                        textBoxNomPatient.Text = dr["Nom_Patient"].ToString();
                        textBoxPrenomPatient.Text = dr["Prenom_Patient"].ToString();
                        textBoxAge.Text = dr["Age"].ToString();
                        comboBoxConsultation.Text = dr["Nom_Consultant"].ToString();
                        textBoxDiagnostic.Text = dr["Diagnostic"].ToString();
                   }
                }
            con.Close();
        }
    }
}
