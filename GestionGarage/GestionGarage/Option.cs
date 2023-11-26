using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class Option
    {
        private static int increment=0;
        private int id;
        private String nom;
        private decimal prix;
        public Option(decimal prix,String nom) {
            Id = increment;
            this.nom = nom;
            this.prix = prix;
            increment++;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set => id = value; }

        public void Afficher()
        {
            Console.WriteLine(
                $"Option id{Id}\n" +
                $"   Nom: {Nom}\n" +
                $"   Prix: {prix}"
            );
        }
    }
}
