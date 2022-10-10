using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTablero.Consola
{
    internal class ValidacionesInput
    {
        public bool OpcionMenu(string input)
        {
            if (input == "1" || input == "2" || input == "3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
