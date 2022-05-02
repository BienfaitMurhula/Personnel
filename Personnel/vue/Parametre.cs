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
    public partial class Parametre : UserControl
    {
        Controleur c = new Controleur();
        public Parametre()
        {
            InitializeComponent();
        }

        private void Parametre_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1, gunaPanel2);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            new Attribution_fonction().ShowDialog();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            c.appel(panP, new F_Rapport());
        }
    }
}
