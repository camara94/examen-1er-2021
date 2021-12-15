using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // je commence par crée quatre plats
            Plat plat1 = new Plat("Plat 1", 50.3, true, "Un bon plat guinéen");
            Plat plat2 = new Plat("Plat 2", 20.3, false, "Un bon plat tunisien");
            Plat plat3 = new Plat("Plat 3", 10.3, true, "Un bon plat ivorien");
            Plat plat4 = new Plat("Plat 4", 10.3, false, "Un bon plat malien");

            // ici je crée une liste de plats, pour pouvoir l'ajouter au menu à de l'agregation
            List<Plat> plats = new List<Plat>();
            plats.Add(plat1);
            plats.Add(plat2);

            // Je crée un menu et j'ajoute deux plats
            Menu menu = new Menu("Menu 1", 63.8, true, "Coca-cola", plats);
            //Console.WriteLine(menu.ToString()); // Cette ligne pour tester la methode ToString()

            // Je crée un client 
            Client client = new Client("SAKOUVOGUI", "Christine Gnama", 50203106, "christine@gmail.com", 78);
            //Console.WriteLine(client.ToString()); // Cette ligne pour tester la methode ToString()

            List<Repas> repas = new List<Repas>();

            repas.Add(plat3);
            repas.Add(plat3);
            repas.Add(menu);

            Commande commande = new Commande(1, 3, new DateTime(), 5, true, repas, client);
            commande.calculerAddition();
            Console.WriteLine(commande.ToString());

           
        }
    }
}
