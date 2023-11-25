using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class AfficheVehicules:Menu
    {
        public AfficheVehicules():base() {
            Name = nameMenu.Affichevehicules;
        }

        public override void initMenu()
        {
            Menus.Add(new Principal());
            base.initMenu();
        }
        public override void execute()
        {
            base.execute();
        }
        public override void afficher()
        {
            Menu.Garage.Afficher();
        }
        public override bool isselect()
        {
            return false;
        }
        public override bool isClear()
        {
            return false;
        }
    }
}
