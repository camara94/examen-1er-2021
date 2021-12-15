using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRestaurant
{
    class Client
    {
        private String nom;
        private String prenom;
        private double tel;
        private String email;
        private double pointFid;

        public Client(string nom, string prenom, double tel, string email, double pointFid)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.email = email;
            this.pointFid = pointFid;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public double Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public double PointFid { get => pointFid; set => pointFid = value; }

        override
        public string ToString()
        {
            String message = "";
            message += "\n  Je suis " + this.nom + " " + this.prenom + 
                    "\n  vous pouvez me contacter au: " + this.tel +
                    "\n  ou m'envoyer un mail à : " +this.email + 
                    "\n  mon pointFid est: " + this.pointFid + "\n";
            return message;
        }
    }
}
