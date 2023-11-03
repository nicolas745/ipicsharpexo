using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire
{
    internal class CompteCourant : Compte
    {
        private decimal decouvert = 0;
        public CompteCourant(string proprietaire,Decimal solde,Decimal decouver) : base(proprietaire,solde)
        {
            Decouvert = decouver;
        }

        public decimal Decouvert { get => decouvert; set => decouvert = value; }

        public override decimal CalculBenefice()
        {
            return 0;
        }
        public new void Information()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine($"Résumé du compte courant de {Proprietaire}");
            Console.WriteLine("******************************************* ");
            Console.WriteLine($"Solde : {SoldeFinal()}");
            Console.WriteLine($"Découvert autorisé : {decouvert} ");
            base.Information();
        }
    }
}
