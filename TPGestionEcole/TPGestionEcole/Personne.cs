using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Personne
    {
        private String nom;
        private String prenom;
        private int age;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }

        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
        public void Veillier()
        {
            Age++;
        }
        public virtual void Affiche()
        {
            Console.WriteLine($"nom : {Nom} , prenom : {Prenom} , age : {age} ans ");
        }
    }
}
