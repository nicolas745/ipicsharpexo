using GestionGarage.menu;
using GestionGarage.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Moteur moteur1 = new Moteur("M2P", TypeMoteur.essence, 1);
            Moteur moteur2 = new Moteur("K12", TypeMoteur.diesel, 1);

            garage.AjouterVehicule(new Voiture("C3", Marque.audi, moteur1, 1, 3, 10));
            garage.AjouterVehicule(new Camion("Truck",Marque.peugeot,moteur2,1,100,200));
            garage.AjouterVehicule(new Moto("Moto k12", Marque.peugeot, moteur1,2));
           /*
            Console.WriteLine("==========\naffiche tout les motot");
            garage.AfficherMoto();
            Console.WriteLine("==========\naffiche tout les camion");
            garage.AfficherCamion();
            Console.WriteLine("==========\naffiche tout les voiture");
            garage.AfficherVoiture();
            Console.WriteLine("==========\naffiche tout les global");
            garage.Afficher();*/
            Menu menu = new Principal();
            menu.start();

        }
    }
}
