using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBancaire.menu
{
    class Menu
    {
        private List<Menu> menus = new List<Menu>();
        private String description;

        public string Description { get => description; set => description = value; }
        internal List<Menu> Menus { get => menus; set => menus = value; }

        public Menu(String description) {
            Description = description;
        }
        
        public void Printdescription()
        {
            Console.WriteLine(Description);

        }
        public virtual void choix(int i){}
        public virtual Boolean isposible(String responce) { return false; }
        public virtual Menu Change(String responce) { return null; }
        public virtual void Chargemenu() { }
    }
}
