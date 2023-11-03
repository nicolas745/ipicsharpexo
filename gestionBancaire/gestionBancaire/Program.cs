using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gestionBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*GestionDeComptes gestionDeComptes = new GestionDeComptes();
            CompteCourant CompteCourantnico=new CompteCourant("Nicolas", 0, 2000);
            CompteEpargne compteEpargnenico = new CompteEpargne("Nicolas", 0, (decimal)0.0205);
            CompteCourant CompteCourantJeremie = new CompteCourant("Jérémie", 0, 500);
            gestionDeComptes.AjouterCompte(CompteCourantnico);
            gestionDeComptes.AjouterCompte(compteEpargnenico);
            gestionDeComptes.AjouterCompte(CompteCourantJeremie);
            CompteCourantnico.Crediter(1000);
            compteEpargnenico.Crediter(200);
            CompteCourantnico.Debiter(50);
            CompteCourantnico.Crediter(100);
            compteEpargnenico.Crediter(100);
            CompteCourantJeremie.Debiter(500);
            CompteCourantJeremie.Debiter(200, CompteCourantnico);
            gestionDeComptes.AfficherComptesCourant();
            gestionDeComptes.AfficherComptesEpargne();
            */
            new InterfaceMenu();
        }
    }
}
