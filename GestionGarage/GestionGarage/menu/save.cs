using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class save:Menu
    {
        public save() {
            Name = nameMenu.save;
        }
        public override void execute()
        {
            base.execute();
            gestiondata data =new gestiondata();
            data.initVehicules();
            foreach(Vehicule vehicule in Garage.Vehicules)
            {
                data.addVehicules(vehicule.data());
            }
            data.save();
        }
        public override void afficher()
        {
        }
        public override bool isClear()
        {
            return false;
        }
        public override bool isselect()
        {
            return false;
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new Principal());
        }
    }
}
