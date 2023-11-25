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
            Back back = new Back(new Principal());
            Menus.Add(back);
            base.initMenu();
        }
        public override void execute()
        {
            Garage garage = new Garage();
            base.execute();
        }
    }
}
