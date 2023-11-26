using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.Vehicules
{
    internal class Voiture:Vehicule
    {
        private int cheveaufiscaut;
        private int nbporte;
        private int tailleCoffre;

        public Voiture(String nom, Marque marque, Moteur moteur,int cheveaufiscaut, int nbporte, int tailleCoffre) : base(nom, marque, moteur)
        {
            this.cheveaufiscaut = cheveaufiscaut;
            this.nbporte = nbporte;
            this.tailleCoffre = tailleCoffre;

        }

        public override void CalculerTaxe()
        {
            throw new NotImplementedException();
        }
        public override void Afficher()
        {
            Console.WriteLine($"fiche Voiture {this.cheveaufiscaut} chevaux fiscaux   avec {this.nbporte} porte et {this.tailleCoffre} volume de couffre:");
            base.Afficher();
        }
        public override Dictionary<string, string> data()
        {
            Dictionary<String,string> senddata = new Dictionary<String,string>();
            senddata.Add("type", "voiture");
            senddata.Add("name", Nom);
            senddata.Add("marque", getidmarque().ToString());
            senddata.Add("Moteur",this.Moteur.Id.ToString());
            senddata.Add("cheveaufiscaut",cheveaufiscaut.ToString());
            senddata.Add("nbporte", nbporte.ToString());
            senddata.Add("tailleCoffre", tailleCoffre.ToString());
            return senddata;
        }
    }
}
