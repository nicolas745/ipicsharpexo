using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire
{

    internal class Operation
    {
        enum Mouvement
        {
            Credit,
            Debit
        }
        private decimal montant;
        private Mouvement mouvement;
        public decimal Montant { get => montant; set => montant = value; }

        public Operation()
        {

        }
        public Boolean isCredit()
        {
            return mouvement==Mouvement.Credit;
        }
        public Boolean isDebit()
        {
            return mouvement == Mouvement.Debit;
        }
        public String TypeMouvement()
        {
            if (mouvement==Mouvement.Debit)
            {
                return "Debit";
            }
            if (mouvement == Mouvement.Credit)
            {
                return "Credit";
            }
            return "";

        }
        public void setCredit(decimal valeur)
        {
            Montant = valeur;
            mouvement = Mouvement.Credit;

        }
        public void setDebit(decimal valeur)
        {
            Montant = valeur;
            mouvement = Mouvement.Debit;

        }
    }
}
