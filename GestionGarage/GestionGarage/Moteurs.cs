using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class Moteurs
    {
        private static List<Moteur> moteurs = new List<Moteur>();
        public Moteurs() {

        }

        public void Add(Moteur moteur) {
            moteurs.Add(moteur);
        }
        public void Afficher()
        {
            Console.WriteLine("List des moteur");
            foreach(Moteur moteur in moteurs)
            {
                moteur.Afficher();
            }
        }
    }
}
