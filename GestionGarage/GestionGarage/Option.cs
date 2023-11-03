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
        public Option() { }
        public void Afficher()
        {
            Console.WriteLine(
                $"Option id{id}\n" +
                $"   Nom: {nom}\n" +
                $"   Prix: {prix}"
            );
        }
    }
}
