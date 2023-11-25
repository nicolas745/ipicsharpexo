﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.Vehicules
{
    internal class Camion : Vehicule
    {
        private int nbEssieu;
        private int poids;
        private int volume;
        public Camion(String nom, Marque marque, Moteur moteur,int nbEssieu, int poids, int volume) : base(nom, marque, moteur) {
            this.poids = poids;
            this.volume = volume;
            this.nbEssieu = nbEssieu;
        }
        public override void CalculerTaxe()
        {
            throw new NotImplementedException();
        }
        public override void Afficher()
        {
            Console.WriteLine("fiche camion ");
            base.Afficher();
        }
    }
}
