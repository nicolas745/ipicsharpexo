using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class AfficheVehicules:Menu
    {
        private Garage garage = new Garage();
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
            garage.Afficher();
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
