using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amira
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultation fm = new Consultation();
            fm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionPersonnel fm = new GestionPersonnel();
            fm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionPatient fm = new GestionPatient();
            fm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistiques fm = new Statistiques();
            fm.Show();
        }
    }
}
