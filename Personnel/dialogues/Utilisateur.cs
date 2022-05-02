using Personnel.controlleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel.dialogues
{
    public partial class Utilisateur : Form
    {
        Controleur c = new Controleur();
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2);
            c.chargement("v_utilisateur", dataGridView1);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
           // c.addAvoir(c.id,)
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
