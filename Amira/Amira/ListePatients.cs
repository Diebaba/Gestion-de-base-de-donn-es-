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
    public partial class ListePatients : Form
    {
        MySqlDataAdapter pagingAdapter;
        DataSet pagingDS;
        int scrollVal;


        public ListePatients()
        {
            InitializeComponent();
            scrollVal = 0;
            string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT * FROM Patients";
            MySqlConnection connection = new MySqlConnection(connectionString);
            pagingAdapter = new MySqlDataAdapter(sql, connection);
            pagingDS = new DataSet();
            connection.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "Patients_table");
            connection.Close();
            dataGridView1.DataSource = pagingDS;
            dataGridView1.DataMember = "Patients_table";
        }

        private void ListeConsultation_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionPatient fm = new GestionPatient();
            fm.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GestionPatient fm = new GestionPatient();
            fm.Show();

        }
    }
}
