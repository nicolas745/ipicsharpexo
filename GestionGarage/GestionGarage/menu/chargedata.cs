using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class chargedata:Menu
    {
        private gestiondata gestiondata = new gestiondata();
        public chargedata() {
            Name = nameMenu.chargedata;
        }
        public override void execute()
        {
            base.execute();
            List<Dictionary<String,String>> datamoteur = gestiondata.getmoteur();
            Garage garage = new Garage();
            garage.init();
            List<Dictionary<String, String>> datavehicule = gestiondata.getVehicule();
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new Principal());
        }
        public override bool isClear()
        {
            return false;
        }
        public override void afficher()
        {
        }
        public override bool isselect()
        {
            return false;
        }
    }
}
