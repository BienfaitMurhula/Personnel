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
    public partial class Service : Form
    {
        Controleur c = new Controleur();
        public Service()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2);
            c.chargement("v_service", dataGridView1);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if(c.id == 0)
            {
                c.addService(c.id, designation, dataGridView1, "v_service");
            }
            else { }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.addService(c.id, designation, dataGridView1, "v_service");
            }
            else { }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.supprimer(c.id, "v_service", "id", dataGridView1, "v_service");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c.depacer_Servi(c.id, e, designation, dataGridView1);
        }
    }
}
