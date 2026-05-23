using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        casoList.AgregarAlumno(new Alumno(1, "Ana Pérez", 8.5));
        casoList.AgregarAlumno(new Alumno(2, "Luis Gómez", 7.2));
        casoList.AgregarAlumno(new Alumno(3, "Marta López", 9.0));

        Console.WriteLine("=== Lista Alumnos ===");
        foreach (var a in casoList.ObtenerLista())
            Console.WriteLine(a);

        Console.WriteLine("\n=== Buscar; 'Ana Pérez' ===");
        var encontrado = casoList.BuscarPorNombre("Ana Pérez");
        if (encontrado != null)
            Console.WriteLine(encontrado);
        else
            Console.WriteLine("No existe");

        Console.WriteLine("\n=== Buscar: 'Carlos Ruiz' ===");
        var noEncontrado = casoList.BuscarPorNombre("Carlos Ruiz");
        if (noEncontrado != null)
            Console.WriteLine(noEncontrado);
        else
            Console.WriteLine("No existe");

        Alumno? aEliminar = casoList.BuscarPorNombre("Luis Gómez");
        if (aEliminar != null)
        {
            casoList.EliminarAlumno(aEliminar);
            Console.WriteLine("\n=== Se eliminó a: LUIS GÓMEZ ===");
            foreach (var a in casoList.ObtenerLista())
                Console.WriteLine(a);
        }

        casoList.EliminarAlumnoPosicion(0);
        Console.WriteLine("\n=== Alumno eliminado ===");
        foreach (var a in casoList.ObtenerLista())
            Console.WriteLine(a);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        var alumno1 = new Alumno(10, "Roberto Díaz", 8.2);
        var alumno2 = new Alumno(20, "Claudia Méndez", 9.1);
        var alumno3 = new Alumno(30, "Javier Solís", 6.7);
        casoDict.AgregarAlumno(alumno1);
        casoDict.AgregarAlumno(alumno2);
        casoDict.AgregarAlumno(alumno3);

        Console.WriteLine("=== Listado de Alumnos ===");
        foreach (var kvp in casoDict.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {kvp.Key} - {kvp.Value}");

        Console.WriteLine("\n=== Buscar Legajo: 20 ===");
        var encontrado = casoDict.BuscarPorClave(20);
        if (encontrado != null)
            Console.WriteLine(encontrado);
        else
            Console.WriteLine("No existe");

        Console.WriteLine("\n=== Buscar Legajo: 99 ===");
        var noEncontrado = casoDict.BuscarPorClave(99);
        if (noEncontrado != null)
            Console.WriteLine(noEncontrado);
        else
            Console.WriteLine("No existe");

        casoDict.EliminarPorClave(10);
        Console.WriteLine("\n=== Alumno con Legajo 10 Eliminado ===");
        foreach (var kvp in casoDict.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {kvp.Key} - {kvp.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("=== 1. Primer libro ===");
        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine("\n=== 2. Último libro ===");
        Console.WriteLine(casoLinq.GetUltimo());

        Console.WriteLine("\n=== 3. Suma de precios ===");
        Console.WriteLine($"Total: ${casoLinq.GetTotalPrecios():N2}");

        Console.WriteLine("\n=== 4. Promedio de precios ===");
        Console.WriteLine($"Promedio: ${casoLinq.GetPromedioPrecios():N2}");

        Console.WriteLine("\n=== 5. Libros con Id > 15 ===");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine(libro);

        Console.WriteLine("\n=== 6. Lista de títulos con precios ===");
        foreach (var item in casoLinq.GetLibros())
            Console.WriteLine(item);

        Console.WriteLine("\n=== 7. Libro con precio más alto ===");
        Console.WriteLine(casoLinq.GetMayorPrecio());

        Console.WriteLine("\n=== 8. Libro con precio más bajo ===");
        Console.WriteLine(casoLinq.GetMenorPrecio());

        Console.WriteLine("\n=== 9. Libros con precio mayor al promedio ===");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine(libro);

        Console.WriteLine("\n=== 10. Libros ordenados por título descendente ===");
        foreach (var libro in casoLinq.GetOrdenadosPorTituloDescendente())
            Console.WriteLine(libro);
    }
}
