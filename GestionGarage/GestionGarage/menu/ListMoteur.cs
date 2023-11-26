using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class ListMoteur:Menu
    {
        public ListMoteur() {
            Name = nameMenu.listmoteur;
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new Principal());
        }
        public override void afficher()
        {
            new Moteurs().Afficher();
        }
        public override bool isClear()
        {
            return false;
        }
        public override bool isselect()
        {
            return false;
        }
    }
}
