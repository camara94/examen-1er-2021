using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRestaurant
{
    class Menu : Repas
    {
        private String nomBoisson;
        private List<Plat> plats;

        public Menu(String nom, double prix, bool estService, string nomBoisson, List<Plat> plats) : base(nom, prix, estService)
        {
            this.nomBoisson = nomBoisson;
            this.Plats = plats;
        }

        public string NomBoisson { get => nomBoisson; set => nomBoisson = value; }
        internal List<Plat> Plats { get => plats; set => plats = value; }

        public override void ServirRepas()
        {
            this.estService = true;
        }

        override
        public String ToString()
        {
            base.ToString();
            String message = "";
            foreach (Repas r in this.plats)
            {
                message += r.ToString() + "\n";
            }

            message += " la boisson est : " + this.nomBoisson;

            return message;
        }
    }
}
