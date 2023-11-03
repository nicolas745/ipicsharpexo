using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJeuDuPendu
{
    internal class menu
    {

        private static Boolean restar = true;
        public void Startmenu()
        {
            jeux pendu = new jeux();
            pendu.Start();
            Console.WriteLine("Tu veut recommencer? (o/n)");
            String res =Console.ReadLine();
            if(res == "o")
            {
                Console.Clear();
                Startmenu();
            }
        }
    }
}
