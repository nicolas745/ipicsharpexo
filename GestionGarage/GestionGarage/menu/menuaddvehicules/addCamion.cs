using GestionGarage.Vehicules;
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
        public override void execute()
        {
            Console.WriteLine("nom de la Camion?");
            String nom = Console.ReadLine();
            int i = 0;
            Console.WriteLine("List des Marque");
            foreach (Marque suit in (Marque[])Enum.GetValues(typeof(Marque)))
            {
                Console.WriteLine(i + " : " + suit);
                i++;
            }
            int idmarque = -1;
            do
            {
                Console.WriteLine("Entrez un numéro de marque :");
            } while (!int.TryParse(Console.ReadLine(), out idmarque) || idmarque < 0 || idmarque >= Enum.GetValues(typeof(Marque)).Length);
            Marque marque = (Marque)Enum.GetValues(typeof(Marque)).GetValue(idmarque);
            Moteur moteur = new Moteur("nom", TypeMoteur.electrique, 1);
            Menu.Garage.AjouterVehicule(new Camion(nom, marque, moteur, 0, 0,0));
            base.execute();
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
