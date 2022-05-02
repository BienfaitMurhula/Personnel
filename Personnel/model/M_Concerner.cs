using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.model
{
    class M_Concerner
    {
       private int id;
       private string montant;
       private string mois;
       private string date_paiement;
       private string agent;
       private string codepaiement;
       private string message;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }

        public string Mois
        {
            get
            {
                return mois;
            }

            set
            {
                mois = value;
            }
        }

        public string Date_paiement
        {
            get
            {
                return date_paiement;
            }

            set
            {
                date_paiement = value;
            }
        }

        public string Agent
        {
            get
            {
                return agent;
            }

            set
            {
                agent = value;
            }
        }

        public string Codepaiement
        {
            get
            {
                return codepaiement;
            }

            set
            {
                codepaiement = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }
    }
}
