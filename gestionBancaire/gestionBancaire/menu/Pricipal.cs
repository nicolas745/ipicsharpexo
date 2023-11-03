using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire.menu
{
    internal class Pricipal:Menu
    {
        public Pricipal() : base("test") { }
        public override Menu Change(string responce)
        {
            return base.Change(responce);
        }

        public override void choix(int i)
        {
            base.choix(i);
        }

        public override bool isposible(string responce)
        {
            return base.isposible(responce);
        }
        public override void Chargemenu()
        {
            base.Chargemenu();
        }
    }
}
