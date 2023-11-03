using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Ecole
    {
        private List<Eleve> eleves = new List<Eleve>(); 
        private List<Professeur> professeurs = new List<Professeur>();
        private String nom;
        private String adresse;
        private decimal budjet;

        internal List<Eleve> Eleves { get => eleves; set => eleves = value; }
        internal List<Professeur> Professeurs { get => professeurs; set =>professeurs = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }

        public Ecole(String nom, String addresse, decimal budjet){
            this.Nom = nom; 
            this.Adresse = addresse;
            this.budjet = budjet;
        }
        public void AjouterProfesseur(double salaire, String nom, string prenom, int age)
        {
            Professeur professeur = new Professeur(salaire,  nom,  prenom, age);
            Professeurs.Add(professeur);
        }
        public void AjouterEleve(String nom, string prenom, int age)
        {
            Eleve eleve= new Eleve(nom, prenom, age);
            Eleves.Add(eleve);
        }
        public void Afficher()
        {
            Console.WriteLine($"nom : {nom} , address : {adresse} , budjet : {budjet}$");
            Console.WriteLine("List des prof: ");
            foreach(Professeur prof in professeurs)
            {
                prof.Affiche();
            }
            Console.WriteLine("List des Eleve : ");
            foreach(Eleve eleve in Eleves)
            {
                eleve.Affiche();
            }
        }

    }
}
