using System;
using Colecciones;


class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        cargarLibros(10);
        cargarLibros(2);
        biblioteca.listarLibros();

        biblioteca.eliminarLibro("Libro5");
        Console.WriteLine("\nDespués de eliminar 'Libro5':\n");
        biblioteca.listarLibros();

        // Función local para cargar libros
        void cargarLibros(int cantidad)
        {
            bool pude;
            for (int i = 1; i <= cantidad; i++)
            {
                pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                if (pude)
                    Console.WriteLine("Libro" + i + " agregado correctamente.");
                else
                    Console.WriteLine("Libro" + i + " ya existe en la biblioteca.");
            }
        }
    }
}