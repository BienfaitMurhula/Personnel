using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel.interfaces
{
    interface Interface1
    {
        void chargement(string sql, DataGridView d);
        void appel(Panel p, UserControl u);
        void rechercher(string sql, DataGridView dat);
        void chargeCombo(ComboBox cmb, string nomChamp, string nomTable);
        void imprimer(DataTable t, String sql);
    }
}
