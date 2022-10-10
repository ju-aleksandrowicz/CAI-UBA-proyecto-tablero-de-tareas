using ProyectoTablero.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTablero.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidacionesInput v = new ValidacionesInput();
            Tablero tablero1 = new Tablero("Tablero del Proyecto de Juan", "Este tablero está destinado al proyecto de implementación del nuevo sistema.");
            int calculoCodigo = tablero1.Tareas.Count() + 1;
            Tarea t1 = new Tarea(calculoCodigo, "Realizar configuración de usuarios.", "No comenzada");
            tablero1.AgregarTarea(t1);
            Tarea t2 = new Tarea(tablero1.Tareas.Count() + 1, "Redactar la documentación del sistema.", "En proceso");
            tablero1.AgregarTarea(t2);
            Tarea t3 = new Tarea(tablero1.Tareas.Count() + 1, "Hacer pruebas de seguridad.", "Finalizada");
            tablero1.AgregarTarea(t3);

            bool salir = false;
            string opcion;
            List<Tarea> tareasFiltradas;

            do
            {
                Console.WriteLine("¡Bienvenido al sistema de gestión de tareas!" + "\n" + 
                    "Por favor elija una de las siguientes opciones para continuar:" + "\n" +
                    "1 - Mostrar todas las tareas" + "\n" +
                    "2 - Agregar nueva tarea" + "\n" +
                    "3 - Salir" + "\n");

                bool opcionValida = false;

                do
                {
                    opcion = Console.ReadLine();
                    if (v.OpcionMenu(opcion))
                    {
                        opcionValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida, vuelva a intentarlo.");
                    }
                } while (!opcionValida);

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        tareasFiltradas = tablero1.TraerTareas();
                        foreach(Tarea t in tareasFiltradas)
                        {
                            Console.WriteLine(t.ToString());
                        }
                        Console.Write("Pulse cualquier tecla para volver al menú principal...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el sistema, ¡vuelva pronto!" + "\n" + "Pulse cualquier tecla para cerrar la ventana...");
                        Console.ReadKey();
                        salir = true;
                        break;
                }

            } while (!salir);
        }
    }
}
