using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel.controlleur;
using Personnel.dialogues;

namespace Personnel.user
{
    public partial class F_Rapport : UserControl
    {
        Controleur c = new Controleur();
        public F_Rapport()
        {
            InitializeComponent();
        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            new FCarte().ShowDialog();
        }

        private void F_Rapport_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel2, gunaPanel1, gunaPanel3, gunaPanel4);
            c.chargement("vue_agent", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c.deplaceragent(e, c.id, noms, sexe, fonct, photo, dataGridView1);
            c.matricule(c.id, matricule);
            timer1.Enabled = true;
            if (matricule.Text != "")
            {
                c.Qrcode(code, matricule.Text);
                if (code.Image != null)
                {
                    //code pour enregistrer la carte
                }
                else
                {
                    MessageBox.Show("Le code doit être générer svp !");
                }
            }
            else
            {
                MessageBox.Show("Le matricule ne doit pas être vide \n veuillez selectionner une perssonne dans la table ");
            }

        }
    }
}
