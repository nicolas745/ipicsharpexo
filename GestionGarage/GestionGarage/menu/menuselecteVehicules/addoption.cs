using GestionGarage.myexception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu.menuselecteVehicules
{
    internal class addoption:Menu
    {
        private int id;
        public addoption(int id):base() {
            this.id = id;
            Name = nameMenu.addoption;
        }
        public override void execute()
        {
            if(Options.Listoption.Count()==0)
            {
                Console.WriteLine("pas posible de chosir une option");
                return;
            }
            Console.WriteLine("List de option");
            for (int i= 0;i < Options.Listoption.Count();i++)
            {
                Option option = Options.Listoption[i];
                Console.WriteLine(i + " : " + option.Nom);
            }
            Console.WriteLine("choisi une option");
            String res = Console.ReadLine();
            if(int.TryParse(res, out int idres))
            {
                if(idres <0 ||  idres >= Options.Listoption.Count())
                {
                    throw new selectoptionException();
                }
                Garage.Vehicules[id].AjouterOption(Options.Listoption[idres]);
            }
            base.execute();
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new selecteVehicule(id));
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
    }
}
