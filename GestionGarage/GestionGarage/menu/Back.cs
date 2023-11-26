using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class Back:Menu
    {
        private Menu backmenu;
        public Back(Menu backmenu):base() {
            this.backmenu = backmenu;
            Name = nameMenu.back;
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(backmenu);
        }
        public override bool isselect()
        {
            return false;
        }
    }
}
