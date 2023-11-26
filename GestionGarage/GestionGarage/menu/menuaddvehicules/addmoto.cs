using GestionGarage.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu.menuaddvehicules
{
    internal class addmoto:Menu
    {
        public addmoto():base() {
            Name = nameMenu.addMoto;
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new addVehicules());
        }
        public override void execute()
        {
            Console.WriteLine("nom de la moto?");
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
            new Garage().AjouterVehicule(new Moto(nom, marque, moteur,1));
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