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
    public partial class ListeConsultation : Form
    {
        MySqlDataAdapter pagingAdapter;
        DataSet pagingDS;
        int scrollVal;
       
        

        public ListeConsultation()
        {
            InitializeComponent();
            scrollVal = 0;
            string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT NUMERO,NOM_PATIENT,PRENOM_PATIENT,AGE,NOM_CONSULTANT,DIAGNOSTIC FROM Consultation WHERE Supprimer=0";
            MySqlConnection connection = new MySqlConnection(connectionString);
            pagingAdapter = new MySqlDataAdapter(sql, connection);
            pagingDS = new DataSet();
            connection.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "Consultation_table");
            connection.Close();
            dataGridView1.DataSource = pagingDS;
            dataGridView1.DataMember = "Consultation_table";

        }

        private void ListeConsultation_Load(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*int index = this.dataGridView1.CurrentRow.Index;
            this.dataGridView1.Rows.RemoveAt(index);*/
            int MyInt = (int)dataGridView1.CurrentCell.Value;
            string MyString = dataGridView1.CurrentCell.Value.ToString();
            this.dataGridView1.Rows.RemoveAt(MyInt);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - 10;
            if (scrollVal <= 0)
            {
                scrollVal = 0;
            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "consultation_table");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal + 10;
            if (scrollVal > 23)
            {
                scrollVal = 18;
            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "consultation_table");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultation fm = new Consultation();
            fm.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            
            //int index = this.dataGridView1.CurrentRow.Index;
            //this.dataGridView1.Rows.RemoveAt(index);
            int MyInt = (int)dataGridView1.CurrentCell.Value;
            Console.WriteLine("myint = " + MyInt);
            //string MyString = dataGridView1.CurrentCell.Value.ToString();
            //this.dataGridView1.Rows.RemoveAt(MyInt);

            string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "UPDATE `Consultation` SET `Supprimer`=true WHERE `Numero` =MyInt";
            MySqlConnection connection = new MySqlConnection(connectionString);
             pagingAdapter = new MySqlDataAdapter(sql, connection);
             pagingDS = new DataSet();
             connection.Open();
           // pagingAdapter.Fill(pagingDS, scrollVal, 10, "Consultation_table");
          //  dataGridView1.DataSource = pagingDS;
           // InitializeComponent();
            scrollVal = 0;
            string sql1 = "SELECT NUMERO,NOM_PATIENT,PRENOM_PATIENT,AGE,NOM_CONSULTANT,DIAGNOSTIC FROM Consultation WHERE Supprimer=0";
//MySqlConnection connection1 = new MySqlConnection(connectionString);
            pagingAdapter = new MySqlDataAdapter(sql1, connection);
            pagingDS = new DataSet();
            
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "Consultation_table");
            connection.Close();
            dataGridView1.DataSource = pagingDS;
            dataGridView1.DataMember = "Consultation_table";
            







        }


        private void Button3_Click_1(object sender, EventArgs e)
        {
         
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT * FROM Consultation WHERE Numero='"+textBoxRechercher.Text +"'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            connection.Open();
           
            if (textBoxRechercher.Text == "") 
            {
                MessageBox.Show("Veuillez entrer le numéro de consulation que vous désirer retrouver ");
            }else
            {
               
              
                MessageBox.Show("le numero de consultation " + textBoxRechercher.Text +" correspond a  ");
            }
            dataGridView1.DataMember = "Consultation_table";
            connection.Close();


            

        }
    }
}







