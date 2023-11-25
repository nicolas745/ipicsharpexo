using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu.menuaddvehicules
{
    internal class addmoto:Menu
    {
        public addmoto():base() {
            Name = nameMenu.addMoto;
        }
        public override void initMenu()
        {
            Menus.Add(new Back(new addVehicules()));
            base.initMenu();
        }
    }
}
