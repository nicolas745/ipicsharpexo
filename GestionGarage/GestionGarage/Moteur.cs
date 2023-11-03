using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    enum TypeMoteur
    {
        diesel,
        essence,
        hybride,
        electrique
    }
    internal class Moteur
    {
        private static int increlent= 0;
        private int id;
        private String nom;
        private TypeMoteur typeMoteur;
        private int puissance;
        public Moteur(string nom, TypeMoteur typeMoteur, int puissance)
        {
            this.nom = nom;
            this.typeMoteur = typeMoteur;
            this.puissance = puissance;
        }
        public void Afficher()
        {
            Console.WriteLine("nom : ");
        }
    }
}
