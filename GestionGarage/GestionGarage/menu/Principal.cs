using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class Principal:Menu
    {
        public Principal():base() {
            Name = nameMenu.principal;
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new AfficheVehicules());
            Menus.Add(new addVehicules());
            Menus.Add(new selecteVehicule());
            Menus.Add(new Listoption());
            Menus.Add(new listmarques());
            Menus.Add(new ListMoteur());
            Menus.Add(new chargedata());
            Menus.Add(new save());
        }
    }
}
