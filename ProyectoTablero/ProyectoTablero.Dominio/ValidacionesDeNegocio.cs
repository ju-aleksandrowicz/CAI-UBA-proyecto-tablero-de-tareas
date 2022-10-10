using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTablero.Dominio
{
    public class ValidacionesDeNegocio
    {
        public bool EstadoValidado(string estado)
        {
            bool esValido = false;

            if (estado == "No comenzada" || estado == "En proceso" || estado == "Finalizada") { esValido = true; }
            else { esValido = false; }

            return esValido;
        }
    }
}
