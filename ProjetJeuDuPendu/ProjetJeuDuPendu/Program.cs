using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJeuDuPendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le Jeu du Pendu");
            menu jeux = new menu();
            jeux.Startmenu();

        }
    }
}
