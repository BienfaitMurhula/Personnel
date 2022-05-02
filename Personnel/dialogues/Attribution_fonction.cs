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
    public partial class Attribution_fonction : Form
    {
        Controleur c = new Controleur();
        public Attribution_fonction()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (c.id == 0)
            {
                c.addAvoir(c.id, date1, date2, fx, agent, "v_avoir", dataGridView1);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.addAvoir(c.id, date1, date2, fx, agent, "v_avoir", dataGridView1);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.supprimer(c.id, "avoir", "id", dataGridView1, "v_avoir");
            }
        }

        private void Attribution_fonction_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2, gunaPanel3);
            c.chargeCombo(agent, "nom", "v_agent");
            c.chargeCombo(fx, "id", "v_fonction");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c.deplaceravoir(c.id, e, date1, date2, fx, agent, dataGridView1);
        }
    }
}
