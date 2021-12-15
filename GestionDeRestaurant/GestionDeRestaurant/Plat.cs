using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRestaurant
{
    class Plat: Repas
    {
        private String description;
       

        public Plat(String nom, double prix, bool estService, string description): base(nom, prix, estService)
        {
            this.description = description;
        }

        public string Description { get => description; set => description = value; }

        public override void ServirRepas()
        {
            this.estService = true;
        }

        override
        public String ToString()
        {
            base.ToString();
            return " la description est : " + this.description;
        }

    }
}
