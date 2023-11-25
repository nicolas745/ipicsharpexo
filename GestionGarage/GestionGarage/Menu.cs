using GestionGarage.menu;
using GestionGarage.myexception;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [nameMenu("Ajouter un vihecule")]
        addvehicules,
        [nameMenu("Afficher les véhicules")]
        Affichevehicules,
        [nameMenu("retour")]
        back,
        [nameMenu("Exit")]
        exit,
        [nameMenu("Principal")]
        principal
    }
    internal class Menu
    {
        public virtual bool isClear()
        {
            return true;
        }
        public virtual bool isselect()
        {
            return true;
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
            Menus.Add(new Exit());
        }
        public void choix()
        {

        }
        internal List<Menu> Menus { get => menus; set => menus = value; }
        internal nameMenu Name { get => name; set => name = value; }

        public virtual void afficher() {
            Console.WriteLine("List des Option Menu:");
            for(int i=0; i<menus.Count();i++)
            {
                Console.WriteLine(i+ " : "+ GetEnumDisplayMenuName(menus[i].name));
            }
        }
        public virtual void execute() {}
        public virtual Menu selectMenu(String nbString)
        {
            if (! int.TryParse(nbString, out int intValue))
            {
                throw new SelectMenuNotInt();
            }
            if (0> intValue | intValue >= menus.Count)
            {
                throw new SelectMenuException(menus.Count-1);
            }

            return Menus[intValue];
        }
    }
}
