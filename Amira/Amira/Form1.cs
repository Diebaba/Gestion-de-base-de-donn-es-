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
    public partial class Form1 : Form

    {
        MySqlConnection conn = new MySqlConnection(@"Data Source=localhost;Initial Catalog=db_authentification; uid=root;pwd='';");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text ==  "" || textBox4.Text=="")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }else { 
           

            
                conn.Open();
                
               
                
                String strl = "Select * from utilisateurs where Email='" + textBox1.Text + "' and Mot_de_passe='" + textBox4.Text + "' ";
               
                MySqlCommand cmd = new MySqlCommand(strl, conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(strl,conn) ;
                da.Fill(dt);

                if (dt.Rows.Count > 0) 
                {
                    textBox1.Hide();
                    textBox4.Hide();
                    MySqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        this.Hide();
                        Accueil fm = new Accueil();
                        fm.Show();

                    }

                }
                else {
                    MessageBox.Show("Il y a erreur sur l'e-mail ou sur le mot de pass saisie");
                    
                        }
                

               
                conn.Close();

            }



        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ButtonIndcription_Click(object sender, EventArgs e)
        {
            this.Hide();
            NouveauCompte fm = new NouveauCompte();
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
