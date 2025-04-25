using System;
using Colecciones;


class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        cargarLibros(10);
        biblioteca.listarLibros();

        biblioteca.altaLector("Pepe", "12345678");

        Console.WriteLine("TEST Lector inexistente:");
        Console.WriteLine(biblioteca.prestarLibro("Libro3", "12345679"));

        Console.WriteLine("TEST Libro inexistente:");
        Console.WriteLine(biblioteca.prestarLibro("Libr3", "12345678"));

        Console.WriteLine("TEST Exitoso:");
        Console.WriteLine(biblioteca.prestarLibro("Libro3", "12345678");


        biblioteca.prestarLibro("Libro4", "12345678");
        biblioteca.prestarLibro("Libro5", "12345678");

        Console.WriteLine("TEST Tope:");
        Console.WriteLine(biblioteca.prestarLibro("Libro2", "12345678"));

        biblioteca.listarLibros();

        Console.ReadKey();

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