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
    public partial class Presence : Form
    {
        public Presence()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Presence_Load(object sender, EventArgs e)
        {
            Controleur.couleur(gunaPanel1);
        }
    }
}
