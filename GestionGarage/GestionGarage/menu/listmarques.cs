using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class listmarques:Menu
    {
        public listmarques():base() {
            Name = nameMenu.listmarques;
        }
        public override bool isClear()
        {
            return false;
        }
        public override void initMenu()
        {
            Menus.Add(new Principal());
            base.initMenu();
        }
        public override void afficher()
        {
            foreach (Marque suit in (Marque[])Enum.GetValues(typeof(Marque)))
            {
                Console.WriteLine(suit);
            }
        }
        public override bool isselect()
        {
            return false;
        }
    }
}
