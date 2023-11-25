using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class Back:Menu
    {
        public Back(Menu backmenu):base() {
            Menus.Add(backmenu);
            Name = nameMenu.back;
        }

        public override bool isselect()
        {
            return false;
        }
    }
}
