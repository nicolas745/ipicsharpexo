using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire
{
    abstract class Compte
    {
        private List<Operation> operations = new List<Operation>();
        private String proprietaire;
        private decimal solde;

        public decimal Solde { get => solde; set => solde = value; }
        public string Proprietaire { get => proprietaire; set => proprietaire = value; }

        public Compte(String proprietaire,Decimal solde)
        {
            Proprietaire = proprietaire;
            Solde = solde;
        }
        public void Crediter(decimal Montant)
        {
            Solde += Montant;
            Operation operation = new Operation();
            operation.setCredit(Montant);
            operations.Add(operation);
        
        }
        public void Crediter(decimal Montant, Compte compteacrediter)
        {
            compteacrediter.Debiter(Montant);
            Crediter(Montant);
        }
        public void Debiter(decimal Montant)
        {
            Solde -= Montant;
            Operation operation = new Operation();
            operation.setDebit(Montant);
            operations.Add(operation);
        }
        public void Debiter(decimal Montant, Compte compteadebiter)
        {
            compteadebiter.Crediter(Montant);
            Debiter(Montant);
        }
        public abstract decimal CalculBenefice();

        public decimal SoldeFinal()
        {
            return CalculBenefice()+Solde;
        }
        public void Information()
        {

            Console.WriteLine("Opperation : ");
            foreach(Operation operation in operations)
            {
                if (operation.isCredit())
                {
                    Console.WriteLine("Credit : {0}", operation.Montant);
                }
                if(operation.isDebit())
                {
                    Console.WriteLine($"Debit : {operation.Montant}");
                }
            }
        }
    }
}
