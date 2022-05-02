using Personnel.mes_classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.connexion
{
    class Connexion
    {
        public string chemin;

        public void connect()
        {

            ClsConnect.testFile();
            chemin = File.ReadAllText(ClsConstantes.Table.chemin).Trim();

        }
    }
}
