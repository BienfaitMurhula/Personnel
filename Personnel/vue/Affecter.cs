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
    public partial class Affecter : UserControl
    {
        Controleur c = new Controleur();
        public Affecter()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Affecter_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2);
            c.chargement("v_affecter", dataGridView1);
            c.chargeCombo(service, "designation", "service");
            c.chargeCombo(agent, "nom", "agent");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (c.id == 0)
            {
                c.addAvoir(c.id, date1, date2, service, agent, "v_affecter", dataGridView1);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.addAvoir(c.id, date1, date2, service, agent, "v_affecter", dataGridView1);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.supprimer(c.id, "v_affecter", "id", dataGridView1, "v_ffecter");
            }
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            c.rechercher("select * from v_affecter where nom like '%" + recherche.text + "%' or service like '%" + recherche.text + "%' ", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
