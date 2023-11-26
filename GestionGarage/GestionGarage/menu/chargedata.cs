using GestionGarage.Vehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.menu
{
    internal class chargedata:Menu
    {
        private gestiondata gestiondata = new gestiondata();
        public chargedata() {
            Name = nameMenu.chargedata;
        }
        public override void execute()
        {
            base.execute();
            Console.WriteLine("commencement du chargement");
            List<Dictionary<String,String>> datamoteurs = gestiondata.getmoteur();
            Moteurs moteurs = new Moteurs();
            moteurs.init();
            TypeMoteur[] typeMoteurs=(TypeMoteur[])Enum.GetValues(typeof(TypeMoteur));
            foreach (Dictionary<String,String> datamoteur in datamoteurs)
            {
                moteurs.Add(new Moteur(datamoteur["name"], typeMoteurs[int.Parse(datamoteur["TypeMoteur"])], int.Parse(datamoteur["puissance"])));
            }
            Garage garage = new Garage();
            garage.init();
            List<Dictionary<String, String>> datavehicules = gestiondata.getVehicule();
            Marque[] marques= (Marque[])Enum.GetValues(typeof(Marque));
            foreach (Dictionary<String,String> datavehicule in datavehicules)
            {
                switch (datavehicule["type"])
                {
                    case "voiture":
                        garage.AjouterVehicule(new Voiture(datavehicule["name"],
                            marques[int.Parse(datavehicule["marque"])],
                            moteurs.GetMoteur(int.Parse(datavehicule["moteur"])),
                            int.Parse(datavehicule["cheveaufiscaut"]),
                            int.Parse(datavehicule["nbporte"]),
                            int.Parse(datavehicule["tailleCoffre"])));
                        break;
                    case "moto":
                        garage.AjouterVehicule(new Moto(datavehicule["name"],
                            marques[int.Parse(datavehicule["marque"])],
                            
                            moteurs.GetMoteur(int.Parse(datavehicule["moteur"])),
                            int.Parse(datavehicule["Cylindre"])
                            ));
                        break;
                    case "camion":
                        garage.AjouterVehicule(new Camion(datavehicule["type"],
                             marques[int.Parse(datavehicule["marque"])],
                             moteurs.GetMoteur(int.Parse(datavehicule["moteur"])),
                             int.Parse(datavehicule["nbEssieu"]),
                             int.Parse(datavehicule["poids"]),
                             int.Parse(datavehicule["volume"])
                             ));
                        break;
                    default : break;
                }
            }
            Console.WriteLine("chargemnt terminer");
        }
        public override void initMenu()
        {
            base.initMenu();
            Menus.Add(new Principal());
        }
        public override bool isClear()
        {
            return false;
        }
        public override void afficher()
        {
        }
        public override bool isselect()
        {
            return false;
        }
    }
}
