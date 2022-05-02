using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.mes_classes
{
    class ClsConnect
    {
        public static String connec;
        public static String dataS;
        public static String initcat;
        public static String id;
        public static String pass;
 

        public static void testFile()
        {
            if (Directory.Exists(ClsConstantes.Table.InitialDirectory) == true) { }

            else
            {
                Directory.CreateDirectory(ClsConstantes.Table.InitialDirectory);
            }

            if (File.Exists(ClsConstantes.Table.chemin) == true)
            {
                //connec = File.ReadAllText("C:\\cheminBdCredit\\monChemin.txt");
            }
            else
            {
                //FormConfig frm = new FormConfig();
                //frm.ShowDialog();
            }
        }
    }
}
