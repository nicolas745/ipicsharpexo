using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu.menuaddvehicules
{
    internal class addCamion:Menu
    {
        public addCamion():base()
        {
            Name = nameMenu.addCamion;
        }
        public override void initMenu()
        {
            Menus.Add(new Back(new addVehicules()));
            base.initMenu();
        }
    }
}
