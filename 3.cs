using System;
using System.Collections.Generic;

namespace ListaDeTareas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tareas = new List<string>();

            while (true)
            {
                Console.WriteLine("\n--- Menú de Tareas ---");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese la nueva tarea: ");
                            string nuevaTarea = Console.ReadLine();
                            tareas.Add(nuevaTarea);
                            Console.WriteLine("Tarea agregada con éxito.");
                            break;
                        case 2:
                            Console.WriteLine("\n--- Lista de Tareas ---");
                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tareas[i]}");
                            }
                            break;
                        case 3:
                            Console.Write("Ingrese el número de la tarea a eliminar: ");
                            int numTareaEliminar;
                            if (int.TryParse(Console.ReadLine(), out numTareaEliminar) && numTareaEliminar >= 1 && numTareaEliminar <= tareas.Count)
                            {
                                tareas.RemoveAt(numTareaEliminar - 1);
                                Console.WriteLine("Tarea eliminada con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("Número de tarea inválido. Intente nuevamente.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente nuevamente.");
                }
            }
        }
    }
}
