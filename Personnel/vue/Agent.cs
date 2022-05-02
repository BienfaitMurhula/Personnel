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
    public partial class Agent : UserControl
    {
        Controleur c = new Controleur();
        public Agent()
        {
            InitializeComponent();
        }

        private void Agent_Load(object sender, EventArgs e)
        {
           // gunaPanel2.BorderStyle = System.Drawing.Color;
            Controleur.couleur(gunaPanel1, gunaPanel2);
            c.chargement("v_agent", dataGridView1);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (c.id == 0)
            {
                c.agent(c.id, nom, post, prenom, sexe, date, etat, nation, adresse, tel, niveau, photo, "v_agent", dataGridView1);
            }
            else
            {
                MessageBox.Show("veuillez passer à la modification svp !");
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.agent(c.id, nom, post, prenom, sexe, date, etat, nation, adresse, tel, niveau, photo, "v_agent", dataGridView1);
            }
            else
            {
                MessageBox.Show("veuillez passer à l'insertion svp !");
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (c.id > 0)
            {
                c.supprimer(c.id, "agent", "id", dataGridView1, "v_agent");
            }
            else
            {
                MessageBox.Show("veuillez selectionner un élément de la table svp !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c.deplaceragent(e, c.id, nom, post, prenom, sexe, date, etat, nation, adresse, tel, niveau, photo, dataGridView1);
        }

        private void recherche_OnTextChange(object sender, EventArgs e)
        {
          //  c.rechercher("select * from v_affecter where nom like '%" + recherche.text + "%' or service like '%" + recherche.text + "%' ", table);
            c.rechercher("select * from v_agent where nom like '%"  + recherche.text + "%' or postnom like '%" + recherche.Text + "%' or prenom like '%" + recherche.Text + "%' ", dataGridView1);
        }

        private void photo_Click(object sender, EventArgs e)
        {
            c.openPhoto(photo);
        }
    }
}
