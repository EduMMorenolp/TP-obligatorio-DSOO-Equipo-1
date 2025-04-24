using System;
using Colecciones;

namespace Colecciones
{
    public class Biblioteca
    {
        // Lista privada que almacena los libros
        private List<Libro> libros;

        // Constructor: inicializa la lista
        public Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        // Método para buscar un libro por su título
        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
            {
                i++;
            }

            if (i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }

        // Método para agregar un libro
        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            if (buscarLibro(titulo) != null)
            {
                return false;
            }

            Libro nuevoLibro = new Libro(titulo, autor, editorial);
            libros.Add(nuevoLibro);
            return true;
        }

        // Método para listar todos los libros
        public void listarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
                return;
            }

            Console.WriteLine("Libros en la biblioteca:");
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {libros[i]}");
            }
        }

        // Método para eliminar un libro por título
        public bool eliminarLibro(string titulo)
        {
            Libro libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                return true;
            }
            return false;
        }
    }

}

