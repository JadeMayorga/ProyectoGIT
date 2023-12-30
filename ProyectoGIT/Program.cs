using System;
using System.Collections.Generic;

class Program
{
    static List<string> tareas = new List<string>();

    static void Main()
    {
        MostrarMenu();
    }

    static void MostrarMenu()
    {
        Console.WriteLine("=== Gestor de Tareas ===");
        Console.WriteLine("1. Agregar tarea");
        Console.WriteLine("2. Ver tareas");
        Console.WriteLine("3. Salir");
        Console.Write("Seleccione una opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AgregarTarea();
                break;
            case "2":
                VerTareas();
                break;
            case "3":
                Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
                break;
        }

        if (opcion != "3")
        {
            MostrarMenu();
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Ingrese la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada con éxito.");
    }

    static void VerTareas()
    {
        Console.WriteLine("=== Lista de Tareas ===");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
        Console.WriteLine("=======================");
    }
}
