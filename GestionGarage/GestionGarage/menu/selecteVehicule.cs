using GestionGarage.menu.menuselecteVehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class selecteVehicule:Menu
    {
        private int idvehicule = -1;
        public selecteVehicule():base() {
            Name = nameMenu.selectvehicules;
        }
        public selecteVehicule(int id)
        {
            idvehicule=id;
        }
        private bool res = true;
        public override void execute()
        {
            if (idvehicule!=-1)
            {
                return;
            }
            if(Garage.Vehicules.Count()==0)
            {
                return;
            }
            do
            {
                Console.WriteLine("Entrez le id vehicules :");
            } while (int.TryParse(Console.ReadLine(), out idvehicule) && (!new Garage().isexitevehicule(idvehicule)));

            base.execute();
        }
        public override void afficher()
        {
            if(res)
            {
                base.afficher();
            }
        }
        public override bool isClear()
        {
            return res;
        }
        public override void initMenu()
        {
            base.initMenu();
            Classback = new Principal();
            Menus.Add(new delVehicules(idvehicule));
            Menus.Add(new afficheoption(idvehicule));
            Menus.Add(new addoption(idvehicule));
            Menus.Add(new delOption(idvehicule));
        }
        public override bool isselect()
        {
            return res;
        }
    }
}
