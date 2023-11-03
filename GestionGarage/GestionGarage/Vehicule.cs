using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    enum Marque
    {
        peugeot,
        renault,
        citroen,
        audi,
        ferrari
    }
    abstract class Vehicule
    {
        private static int Increment = 0;
        private int id = 0;
        private String nom;
        private decimal prixHT;
        private Marque marque;
        private List<Option> options;
        private Moteur moteur;
        public Vehicule(String nom, Marque marque, Moteur moteur) {
            this.nom = nom;
            this.marque = marque;
            this.moteur = moteur;
        }
        public void AfficherOptions()
        {
            foreach (Option option in options)
            {
                option.Afficher();
            }
        }
        public void AjouterOption(Option option)
        {
            options.Add(option);
        }
        public virtual void Afficher()
        {
        }

        public abstract void CalculerTaxe();
        public decimal PrixTotal()
        {
            return 0;
        }

    }
}
