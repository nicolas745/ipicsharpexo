using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.Vehicules
{
    internal class Moto : Vehicule
    {
        private int Cylindre;
        public Moto(String nom, Marque marque, Moteur moteur,int Cylindre) : base(nom, marque, moteur) {
            this.Cylindre = Cylindre;
        }
        public override void CalculerTaxe()
        {
            throw new NotImplementedException();
        }
        public override void Afficher()
        {
            Console.WriteLine($"Fiche Moto Cylindre {this.Cylindre}");
            Console.WriteLine();
            base.Afficher();

        }
    }
}
