using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.myexception
{
    internal class SelectMenuNotIntException: Exception
    {
        public SelectMenuNotIntException() {
            Console.WriteLine("error, ce n'est pas un nombre");
        }
    }
}
