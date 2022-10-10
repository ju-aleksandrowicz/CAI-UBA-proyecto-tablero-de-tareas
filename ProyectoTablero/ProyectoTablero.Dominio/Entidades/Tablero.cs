using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTablero.Dominio
{
    public class Tablero
    {
        protected string _titulo;
        protected string _descripcion;
        protected List<Tarea> _tareas;
        protected DateTime _fechaInicioProyecto;

        public string Titulo { get { return _titulo; } }
        public string Descripcion { get { return _descripcion; } }
        public List<Tarea> Tareas { get { return _tareas; } }
        public DateTime FechaInicioProyecto { get { return _fechaInicioProyecto; } }

        public Tablero(string titulo, string descripcion)
        {
            _titulo = titulo;
            _descripcion = descripcion;
            _tareas = new List<Tarea>();
            _fechaInicioProyecto = DateTime.Now;
        }

        public void AgregarTarea(Tarea nuevaTarea)
        {
            _tareas.Add(nuevaTarea);
        }

        public void CambiarEstado(int codigo, string nuevoEstado)
        {
            foreach (Tarea ta in _tareas)
            {
                if (ta.Codigo == codigo)
                {
                    ta.Estado = nuevoEstado;
                }
            }
        }

        public List<Tarea> TraerTareas()
        {
            return _tareas;
        }

        public List<Tarea> TraerTareas(string estado)
        {
            List<Tarea> tareasFiltradas = new List<Tarea>();

            foreach (Tarea tarea in _tareas)
            {
                if (tarea.Estado == estado)
                {
                    tareasFiltradas.Add(tarea);
                }
            }

            return tareasFiltradas;
        }

        public Tarea TraerTareaMasAntigua()
        {
            Tarea tareaMasAntigua = new Tarea();

            foreach (Tarea tarea in _tareas)
            {
                if(tarea.FechaAlta < tareaMasAntigua.FechaAlta)
                {
                    tareaMasAntigua = tarea;
                }
            }

            return tareaMasAntigua;
        }
    }
}
