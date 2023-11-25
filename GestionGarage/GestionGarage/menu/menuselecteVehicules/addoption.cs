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
    }
}
