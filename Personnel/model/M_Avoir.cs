using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.model
{
    class M_Avoir
    {
        int id;
        DateTime date_debut;
        DateTime date_fin;
        string fonction;
        string agent;

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

        public DateTime Date_debut
        {
            get
            {
                return date_debut;
            }

            set
            {
                date_debut = value;
            }
        }

        public DateTime Date_fin
        {
            get
            {
                return date_fin;
            }

            set
            {
                date_fin = value;
            }
        }

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
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
    }
}
