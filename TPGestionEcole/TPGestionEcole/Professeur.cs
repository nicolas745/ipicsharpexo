using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Professeur : Personne
    {
        private List<Eleve> eleves = new List<Eleve>();
        private Double salaire;
        public Professeur(double salaire,String nom, string prenom, int age) :
            base(nom,prenom,age)
        {
            this.salaire = salaire;
        }

        public double Salaire { get => salaire; set => salaire = value; }

        public override void Affiche()
        {
            base.Affiche();
            Console.WriteLine($"salaire : {salaire}");
        }
    }
}
