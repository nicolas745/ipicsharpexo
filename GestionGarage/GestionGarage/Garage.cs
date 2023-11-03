using GestionGarage.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class Garage
    {
        private List<Vehicule> vehicules = new List<Vehicule>();
        public Garage()
        {
        }
        public void Afficher()
        {
            foreach(Vehicule vehicule in vehicules)
            {
                vehicule.Afficher();
            }
        }
        public void AfficherVoiture()
        {
            foreach (Vehicule vehicule in vehicules)
            {
                if(vehicule is Voiture)
                {
                    vehicule.Afficher();
                }
            }
        }
        public void AfficherCamion()
        {
            foreach (Vehicule vehicule in vehicules)
            {
                if (vehicule is Camion)
                {
                    vehicule.Afficher();
                }
            }
        }

        public void AfficherMoto()
        {
            foreach (Vehicule vehicule in vehicules)
            {
                if (vehicule is Moto)
                {
                    vehicule.Afficher();
                }
            }
        }
        public void AjouterVehicule(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
        }
        public void TrierVehicule()
        {
            Console.WriteLine("Moto");
            AfficherMoto();
            Console.WriteLine("Camion");
            AfficherCamion();
            Console.WriteLine("Voiture");
            AfficherVoiture();
        }
    }
}
