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
    public partial class ListePersonnel : Form
    {
        

        MySqlDataAdapter pagingAdapter;
        DataSet pagingDS;
        int scrollVal;


        public ListePersonnel()
        {
            InitializeComponent();
            scrollVal = 0;
            string connectionString = "Data Source=localhost;Initial Catalog=gestion-poste-de-santé; uid=root;pwd='';";
            string sql = "SELECT * FROM Personnel";
            MySqlConnection connection = new MySqlConnection(connectionString);
            pagingAdapter = new MySqlDataAdapter(sql, connection);
            pagingDS = new DataSet();
            connection.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "Personnel_table");
            connection.Close();
            dataGridView1.DataSource = pagingDS;
            dataGridView1.DataMember = "Personnel_table";
        }

        private void ListeConsultation_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - 10;
            if (scrollVal <= 0)
            {
                scrollVal = 0;
            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "personnel_table");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal + 10;
            if (scrollVal > 23)
            {
                scrollVal = 18;
            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 10, "personnel_table");
        }

       
        private void Button4_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer cette ligne?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                int index = this.dataGridView1.CurrentRow.Index;
                this.dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Ligne supprimée avec succée");
            }
            else
                MessageBox.Show("La suppression est annulée");

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GestionPersonnel fm = new GestionPersonnel();
            fm.Show();

        }
    }
}

