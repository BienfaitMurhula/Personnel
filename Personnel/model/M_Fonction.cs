using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.model
{
    class M_Fonction
    {
        private int id;
        private string designation;
        private DateTime date;
        private float salaire;

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

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public float Salaire
        {
            get
            {
                return salaire;
            }

            set
            {
                salaire = value;
            }
        }
    }
}
