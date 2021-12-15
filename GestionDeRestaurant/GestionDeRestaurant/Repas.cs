using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRestaurant
{
    abstract class Repas
    {
        protected String nom;
        protected double prix;
        protected bool estService;

        public Repas()
        {
            this.nom = "";
            this.prix = 0;
            this.estService = false;
        }

        public Repas(String nom, double prix, bool estService)
        {
            this.nom = nom;
            this.Prix = prix;
            this.estService = estService;
        }

        public string Nom { get => nom; set => nom = value; }
        public double Prix { get => prix; set => prix = value; }
        public bool EstService { get => estService; set => estService = value; }

        public abstract void ServirRepas();

        override
        public String ToString()
        {
            return "Le répas: " + this.nom + " coût: " + this.prix
                + " est service: " + this.estService;
        }
    }
}


