using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTablero.Dominio
{
    public class Tarea
    {
        protected int _codigo;
        protected string _descripcion;
        protected string _estado;
        protected int _orden;
        protected DateTime _fechaAlta;
        protected DateTime _fechaRealizacion;

        public int Codigo { get { return _codigo; }}
        public string Descripcion { get { return _descripcion; }}
        public string Estado { get { return _estado; } set { _estado = value; } }
        public int Orden { get { return _orden; }}
        public DateTime FechaAlta { get { return _fechaAlta; }}
        public DateTime FechaRealizacion { get { return _fechaRealizacion; }}

        public Tarea(int codigo, string descripcion, string estado)
        {
            _descripcion = descripcion;
            _estado = estado;
            _fechaAlta = DateTime.Now;
        }

        public Tarea()
        {

        }

        public override string ToString()
        {
            return "Código: #" + this.Codigo + "\n" +
                "Descripción: " + this.Descripcion + "\n" +
                "Estado: " + this.Estado + "\n" +
                "Fecha de Alta: " + this.FechaAlta + "\n" +
                "Fecha de Realización: " + this.FechaRealizacion + "\n";
        }

        public bool IsFinalizada()
        {
            if(this.Estado == "Finalizada")
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
