using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class Moteurs
    {
        private static List<Moteur> listmoteurs = new List<Moteur>();

        public Moteurs() {

        }

        internal static List<Moteur> Listmoteurs { get => listmoteurs; set => listmoteurs = value; }
        public void init()
        {
            listmoteurs.Clear();
        }
        public Moteur GetMoteur(int id)
        {
            foreach (Moteur moteur in Listmoteurs)
            {
                if (moteur.Id == id)
                {
                    return moteur;
                }
            }
            return null;
        }
        public void Add(Moteur moteur) {
            Listmoteurs.Add(moteur);
        }
        public void Afficher()
        {
            Console.WriteLine("List des moteur");
            foreach(Moteur moteur in Listmoteurs)
            {
                moteur.Afficher();
            }
        }
    }
}
