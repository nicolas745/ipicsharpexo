using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ecole ecole = new Ecole("L'ecole Degaule", "60 de blonais", 200000);
            ecole.AjouterProfesseur(2000.0, "Martin", "Matin", 30);
            ecole.AjouterEleve("Luc", "Besion", 8);
            ecole.AjouterEleve("Adrew", "Garfild", 9);
            ecole.Eleves[0].AjourerMoyenne(14);
            ecole.Eleves[0].AjourerMoyenne(10);
            ecole.Afficher();
        }
    }
}
