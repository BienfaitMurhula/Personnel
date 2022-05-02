using Personnel.controlleur;
using Personnel.dialogues;
using Personnel.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel
{
    public partial class Home : Form
    {
        Controleur c = new Controleur();
        public Home()
        {
            InitializeComponent();
        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            c.appel(pan, new Agent());
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            c.appel(pan, new Fonction());
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            c.appel(pan, new Parametre());
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            new Presence().ShowDialog();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            new Service().ShowDialog();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            c.appel(pan, new Affecter());
        }
    }
}
