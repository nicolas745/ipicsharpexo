using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class delVehicules:Menu
    {
        private int id;
        public delVehicules(int id):base() {
            this.id = id;
            Name = nameMenu.delvehicules;
        }
        public override bool isClear()
        {
            return false;
        }
        public override void execute()
        {
            new Garage().surprimerVehicule(id);
            base.execute();
        }
        public override void afficher()
        {
        }
        public override bool isselect()
        {
            return false;
        }
        public override void initMenu()
        {
            Menus.Add(new Principal());
            base.initMenu();
        }
    }
}
