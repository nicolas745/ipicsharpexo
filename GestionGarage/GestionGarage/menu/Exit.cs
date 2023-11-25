using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class Exit:Menu
    {
        public Exit() {
            Name = nameMenu.exit;
        }
        public override void execute()
        {
            Environment.Exit(0);
            base.execute();
        }
    }
}
