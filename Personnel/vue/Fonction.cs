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

namespace Personnel.user
{
    public partial class Fonction : UserControl
    {
        Controleur c = new Controleur();
        public Fonction()
        {
            InitializeComponent();
        }

        private void Fonction_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2, gunaPanel3);
            c.chargement("v_fonction", dataGridView1);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.supprimer(c.id, "v_fonction", "id", dataGridView1, "v_fonction");
            }
            else { }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (c.id == 0)
            {
                c.fonction(c.id, design, date1, salaire, "v_fonction", dataGridView1, "Fonction ajoutée", "Erreur d'ajout");
            }
            else { }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.fonction(c.id, design, date1, salaire, "v_fonction", dataGridView1, "Fonction modifiée", "Erreur de modification");
            }
            else { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c.deplacerfx(e, c.id, design, date1, salaire, dataGridView1);
        }
    }
}
