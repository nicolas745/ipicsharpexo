﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class AfficheVehicules:Menu
    {
        public AfficheVehicules():base() {
            Name = nameMenu.Affichevehicules;
        }

        public override void initMenu()
        {

            base.initMenu();
            Menus.Add(new Principal());
        }
        public override void execute()
        {
            base.execute();
        }
        public override void afficher()
        {
            new Garage().Afficher();
        }
        public override bool isselect()
        {
            return false;
        }
        public override bool isClear()
        {
            return false;
        }
    }
}
