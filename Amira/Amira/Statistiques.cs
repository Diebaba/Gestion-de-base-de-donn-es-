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
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil fm = new Accueil();
            fm.Show();
        }
    }
}
