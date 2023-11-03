using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Eleve :Personne
    {
        private List<Double> notes = new List<Double>();
        public Eleve(String nom, String prenom, int age):base(nom,prenom,age) {}
        public override void Affiche()
        {
            base.Affiche();
            Double Moyenne = MoyenneGen();
            if (Moyenne==-1)
            {
                Console.WriteLine("pas de note");
            }
            else
            {
                Console.WriteLine($"moyenne {MoyenneGen()}");
            }
        }
        public Double MoyenneGen()
        {
            Double res = 0.0;
            foreach(Double note in notes)
            {
                res += note;
            }
            if (notes.Count!=0)
            {   
                return res/notes.Count;
            }
            return -1.0;
        }
        public void AjourerMoyenne(Double note)
        {
            notes.Add(note);
        }
    }
}
