using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire
{
    internal class GestionDeComptes
    {
        private List<Compte> comptes = new List<Compte>();
        public void AjouterCompte(Compte compte)
        {
            comptes.Add(compte);
        }
        public void AfficherComptesEpargne()
        {
            foreach (Compte compte in comptes)
            {
                if (compte is CompteEpargne)
                {
                    CompteEpargne compte1 = compte as CompteEpargne;
                    compte1.Information();
                }
            }
        }
        public void AfficherComptesCourant()
        {
            foreach (Compte compte in comptes)
            {
                if (compte is CompteCourant)
                {
                    CompteCourant compte1 = compte as CompteCourant;
                    compte1.Information();
                }
            }
        }
    }
}
