using System;
using System.Collections.Generic;

namespace GestorTareas
{
    class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Menú del Gestor de Tareas:");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Eliminar Tarea");
                Console.WriteLine("3. Listar Tareas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese su opción:");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AgregarTarea();
                            break;
                        case 2:
                            EliminarTarea();
                            break;
                        case 3:
                            ListarTareas();
                            break;
                        case 4:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, ingrese un número entre 1 y 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                }

                Console.WriteLine();
            }
        }

        static void AgregarTarea()
        {
            Console.WriteLine("Ingrese la tarea:");
            string tarea = Console.ReadLine();
            tareas.Add(tarea);
            Console.WriteLine("Tarea agregada exitosamente.");
        }

        static void EliminarTarea()
        {
            Console.WriteLine("Ingrese el índice de la tarea a eliminar:");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < tareas.Count)
            {
                tareas.RemoveAt(indice);
                Console.WriteLine("Tarea eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Por favor, ingrese un índice válido.");
            }
        }

        static void ListarTareas()
        {
            if (tareas.Count > 0)
            {
                Console.WriteLine("Tareas:");
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i}. {tareas[i]}");
                }
            }
            else
            {
                Console.WriteLine("No hay tareas disponibles.");
            }
        }
    }
}