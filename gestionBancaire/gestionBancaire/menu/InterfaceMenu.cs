using gestionBancaire.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire
{
    class InterfaceMenu
    {
        public InterfaceMenu()
        {
            Boolean res = true;
            Menu menu = new Pricipal();
            menu.Chargemenu();
            while (res)
            {
                res = false;
                menu.Printdescription();
                String responce = Console.ReadLine();
                res = menu.isposible(responce);
                if (res)
                {
                    menu = menu.Change(responce);
                }
            }
        }

    }
}
