using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.model
{
    class M_Agent
    {
        private int id;
        private string nom;
        private string postnom;
        private string prenom;
        private string sexe;
        private string date;
        private string etat;
        private string nationalite;
        private string adresse;
        private string telephone;
        private string niveau;
        private Byte[] photo;

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

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return postnom;
            }

            set
            {
                postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        public string Date
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

        public string Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }

        public string Nationalite
        {
            get
            {
                return nationalite;
            }

            set
            {
                nationalite = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Niveau
        {
            get
            {
                return niveau;
            }

            set
            {
                niveau = value;
            }
        }

        public byte[] Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }
    }
}
