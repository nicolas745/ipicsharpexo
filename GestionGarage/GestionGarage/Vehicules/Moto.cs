using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.Vehicules
{
    internal class Moto : Vehicule
    {
        public Moto(String nom, Marque marque, Moteur moteur) : base(nom, marque, moteur) { }
        public override void CalculerTaxe()
        {
            throw new NotImplementedException();
        }
    }
}
