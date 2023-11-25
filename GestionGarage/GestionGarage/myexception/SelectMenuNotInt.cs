using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.myexception
{
    internal class SelectMenuNotInt: Exception
    {
        public SelectMenuNotInt() {
            Console.WriteLine("error, ce n'est pas un nombre");
        }
    }
}
