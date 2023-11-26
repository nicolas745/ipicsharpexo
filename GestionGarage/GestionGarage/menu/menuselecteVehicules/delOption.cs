using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu.menuselecteVehicules
{
    internal class delOption:Menu
    {
        private int id;
        public delOption(int id):base() {
            this.id = id;
            Name = nameMenu.delOption;
        }
        public override void execute()
        {
            Console.WriteLine("List de option: ");
           for(int i = 0; i < Garage.Vehicules[id].Options.Count(); i++)
            {
                Option option = Garage.Vehicules[id].Options[i];
                Console.WriteLine(i + " : " + option.Nom);
            }
            int res = -1;
            do
            {
                Console.WriteLine("Choisi une option? {id}");
                Console.WriteLine(id);
            } while (!int.TryParse(Console.ReadLine(),out res) && (res<0 || Garage.Vehicules[id].Options.Count()<=res));
            Garage.Vehicules[id].Options = Garage.Vehicules[id].Options.Where((element,index)=>index!=res).ToList();
            base.execute();
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new selecteVehicule(id));
        }
        public override bool isClear()
        {
            return false;
        }
        public override void afficher(){ }
        public override bool isselect()
        {
            return false;
        }
    }
}
