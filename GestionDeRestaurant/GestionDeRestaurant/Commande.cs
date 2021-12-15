using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRestaurant
{
    class Commande : IComparable, IAddtion
    {

        private int numero;
        private int numTable;
        private DateTime date;
        private int nbCouvert;
        private bool fidelite;
        private double montant;
        private List<Repas> repas;
        private Client client;

        public Commande(int numero, int numTable, DateTime date, int nbCouvert, bool fidelite, List<Repas> repas, Client client)
        {
            this.numero = numero;
            this.numTable = numTable;
            this.date = date;
            this.NbCouvert = nbCouvert;
            this.Fidelite = fidelite;
            this.Repas = repas;
            this.Client = client;
        }

        public int Numero { get => numero; set => numero = value; }
        public int NumTable { get => numTable; set => numTable = value; }
        public DateTime Date { get => date; set => date = value; }
        public int NbCouvert { get => nbCouvert; set => nbCouvert = value; }
        public bool Fidelite { get => fidelite; set => fidelite = value; }
        public double Montant { get => montant; set => montant = value; }
        internal List<Repas> Repas { get => repas; set => repas = value; }
        internal Client Client { get => client; set => client = value; }

        public void calculerAddition()
        {
            this.montant = 0;
            /*
             * Grâce à l'association de plusieurs à plusieur
             * entre la classe Repas et Commande, 
             * j'ai crée une liste de repas dans la classe Commande
             * comme chaque repas à un prix donc la methode calculerAddition()
             * va sommer ou ajouter le prix de tous les repas d'une commande
             * à l'attribut montant
             */
            foreach (Repas r in this.repas)
            {
                this.montant = this.montant + r.Prix;
            }
        }

        public int CompareTo(Object commande)
        {
            Commande command = (Commande)commande;
            /*
             * Comme rien n'est précisé ici, je vais partir
             * du principe que si le montant d'une commande 
             * à une autre alors elle supérieure
             */
            if( this.montant > command.Montant )
            {
                return 1;
            } else if( this.montant < command.montant )
            {
                return -1;
            } else
            {
                // c'est à dire si elles sont égales
                return 0;
            }
        }

        public void AjouterRepas( Repas r )
        {
            this.repas.Add(r);
        }

        public bool EtatCommande()
        {
            if( this.montant>0 )
            {
                return true;
            } else
            {
                return false;
            }
        }

        override
        public String ToString()
        {
            String message = "";
            message += "===Les infos sur la commande:===";
            message += "\n  Numéro: " + this.numero;
            message += "\n  Numéro de la table: " + this.numTable;
            message += "\n  Nombre de couverture: " + this.nbCouvert;
            message += "\n  Fidélité: " + this.fidelite;
            message += "\n  Montant: " + this.montant;
            message += "\n  Date: " + this.date;
            message += "\n\nNombre de répas: " + this.repas.Count;
            for( int i=0; i < this.repas.Count; i++ )
            {
                message += "\n    " + (i+1) + ") " + this.repas[i].ToString();
            }
            message += "\n\nLes informations sur le client:";
            message += this.client.ToString();
            return message;
        }

    }
}
