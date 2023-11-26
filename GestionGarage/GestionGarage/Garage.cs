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
        private static List<Vehicule> vehicules = new List<Vehicule>();

        internal static List<Vehicule> Vehicules { get => vehicules; set => vehicules = value; }

        public Garage()
        {
        }
        public void init()
        {
            vehicules.Clear();
        }
        public Vehicule getvehiculeid(int id)
        {
            foreach(Vehicule vehicule in Vehicules)
            {
                if(vehicule.Id == id) return vehicule;
            }
            return null;
        }
        public bool isexitevehicule(int id)
        {
            foreach(Vehicule vehicule in vehicules)
            {
                if(vehicule.Id == id) return true;
            }
            return false;
        }
        public void surprimerVehicule(int id)
        {
            vehicules = vehicules.Where((element,index) =>element.Id!=id).ToList();
        }
        public void AjouterVehicule(Vehicule vehicule)
        {
            Vehicules.Add(vehicule);
        }

        public void Afficher()
        {
            Console.WriteLine("la list de tous les vehicules : ");
            foreach(Vehicule vehicule in Vehicules)
            {
                vehicule.Afficher();
            }
        }
        public void AfficherVoiture()
        {
            foreach (Vehicule vehicule in Vehicules)
            {
                if(vehicule is Voiture)
                {
                    vehicule.Afficher();
                }
            }
        }
        public void AfficherCamion()
        {
            foreach (Vehicule vehicule in Vehicules)
            {
                if (vehicule is Camion)
                {
                    vehicule.Afficher();
                }
            }
        }

        public void AfficherMoto()
        {
            foreach (Vehicule vehicule in Vehicules)
            {
                if (vehicule is Moto)
                {
                    vehicule.Afficher();
                }
            }
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
