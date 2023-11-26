using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu.menuselecteVehicules
{
    internal class afficheoption:Menu
    {
        private int id;
        public afficheoption(int id):base()
        {
            this.id = id;
            Name = nameMenu.afficheoption;
        }
        public override bool isClear()
        {
            return false;
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new selecteVehicule(id));
        }
        public override void afficher()
        {
            new Garage().getvehiculeid(this.id).AfficherOptions();
        }
        public override bool isselect()
        {
            return false;
        }
    }
}
