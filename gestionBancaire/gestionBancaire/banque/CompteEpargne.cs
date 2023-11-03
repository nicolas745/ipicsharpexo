using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire
{
    internal class CompteEpargne : Compte
    {
        private Decimal Taux;
        public CompteEpargne(string proprietaire, decimal solde, decimal taux) : base(proprietaire, solde)
        {
            Taux = taux;
        }

        public override decimal CalculBenefice()
        {
            return Solde*Taux;
        }
        public new void Information()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"Résumé du Compte Epargne de {Proprietaire}");
            Console.WriteLine("******************************************* ");
            Console.WriteLine($"Solde : {SoldeFinal()}");
            Console.WriteLine($"Taux d’abondement : {Taux*100}%");
            base.Information();
        }
    }
}
