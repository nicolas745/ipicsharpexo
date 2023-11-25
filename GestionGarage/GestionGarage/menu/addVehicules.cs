using GestionGarage.menu.menuaddvehicules;
using GestionGarage.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class addVehicules:Menu
    {
        public addVehicules():base() {
            Name = nameMenu.addvehicules;
        }

        public override void initMenu()
        {
            Classback = new Principal();
            Menus.Add(new addCamion());
            Menus.Add(new addvoiture());
            Menus.Add(new addmoto());
            base.initMenu();
        }
    }
}
