using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    internal class SelectMenuException: Exception
    {
        public SelectMenuException(int i) {
            Console.WriteLine($"error menu select doit etre entre 0 a {i}");
        }
    }
}
