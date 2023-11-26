using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage.myexception
{
    internal class notvoitureException : Exception
    {
        public notvoitureException() {
            Console.WriteLine($"il y a pas de voiture");
        }
    }
}
