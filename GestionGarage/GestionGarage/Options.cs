using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class Options
    {
        private static List<Option> listoption = new List<Option>();
        public Options() { }
        internal static List<Option> Listoption { get => listoption; set => listoption = value; }

        public void AddOption(Option option)
        {
            Listoption.Add(option);
        }

        public void Afficher()
        {
            foreach (Option option in listoption)
            {
                option.Afficher();
            }
        }
    }
}
