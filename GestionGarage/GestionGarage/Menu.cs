using GestionGarage.menu;
using GestionGarage.myexception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    public class nameMenuAttribute : Attribute
    {
        public string Value { get; }

        public nameMenuAttribute(string value)
        {
            Value = value;
        }
    }
    enum nameMenu
    {
        [nameMenu("Supprimer un véhicule")]
        delvehicules,
        [nameMenu("Ajouter une moto")]
        addMoto,
        [nameMenu("Ajouter une voiture")]
        addVoiture,
        [nameMenu("Ajouter Camion")]
        addCamion,
        [nameMenu("Ajouter un véhicule")]
        addvehicules,
        [nameMenu("Afficher les véhicules")]
        Affichevehicules,
        [nameMenu("retour")]
        back,
        [nameMenu("Quitter l'application")]
        exit,
        [nameMenu("Principal")]
        principal,
        [nameMenu("Sélectionner un véhicule")]
        selectvehicules,
        [nameMenu("Afficher les options")]
        afficheoption,
        [nameMenu("Ajouter des options")]
        addoption,
        [nameMenu("Afficher les types de moteurs")]
        listmoteur,
        [nameMenu("Afficher les marques")]
        listmarques,
        [nameMenu("Supprimer une option")]
        delOption,
    }
    internal class Menu
    {
        private Menu classback = null;
        public virtual bool isClear()
        {
            return true;
        }
        public virtual bool isselect()
        {
            return true;
        }
        public void start()
        {
            Menu menu = this;
            while (true)
            {
                try
                {
                    menu.execute();
                    menu.initMenu();
                    menu.afficher();
                    Menu lastmenu = menu;
                    menu.GetChoixMenu(ref menu);
                    if (lastmenu.isClear())
                    {
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private String GetChoix()
        {

            String res = Console.ReadLine();
            if ((res != "b" && res != "x"))
            {
                if (!int.TryParse(res, out int intValue))
                {
                    throw new SelectMenuNotInt();
                }
                if (0 > intValue | intValue >= menus.Count)
                {
                    throw new SelectMenuException(menus.Count - 1);
                }
            }
            return res;
        }
        private string GetEnumDisplayMenuName(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribut = (nameMenuAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(nameMenuAttribute));

            return attribut?.Value ?? value.ToString();
        }
        private nameMenu name;
        private List<Menu> menus = new List<Menu>();
        public Menu() {
        }
        public virtual void initMenu()
        {
            Menus = new List<Menu>();
        }
        internal List<Menu> Menus { get => menus; set => menus = value; }
        internal nameMenu Name { get => name; set => name = value; }
        internal Menu Classback { get => classback; set => classback = value; }

        public virtual void afficher() {
            Console.WriteLine(" Menu:");
            if(Classback != null)
            {
                Console.WriteLine("b : " + GetEnumDisplayMenuName(new Back(Classback).name));
            }
            for(int i=0; i<menus.Count();i++)
            {
                Console.WriteLine(i+ " : "+ GetEnumDisplayMenuName(menus[i].name));
            }
            Console.WriteLine("x : " + GetEnumDisplayMenuName(new Exit().name));
        }
        public virtual void execute() {}
        public void GetChoixMenu(ref Menu menu)
        {
            String selectuser = "0";
            if (menu.isselect())
            {
                selectuser = GetChoix();
            }
            switch (selectuser)
            {
                case "b":
                    if (Classback != null)
                    {
                        menu = new Back(Classback);
                    }
                    else
                    {
                        menu = new Back(this);
                    }
                    break;
                case "x":
                    menu = new Exit();
                    break;
                default:
                    menu=  Menus[int.Parse(selectuser)];
                    break;
            }
        }
    }
}
