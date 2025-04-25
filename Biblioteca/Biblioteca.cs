using System;
using Colecciones;

namespace Colecciones
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectoresRegistrados;

        public Biblioteca()
        {
            this.lectoresRegistrados = new List<Lector>();
            this.libros = new List<Libro>();
        }

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

        private Lector buscarLector(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectoresRegistrados.Count && !lectoresRegistrados[i].getDni().Equals(dni))
            {
                i++;
            }

            if (i != lectoresRegistrados.Count)
            {
                lectorBuscado = lectoresRegistrados[i];
            }
            return lectorBuscado;
        }

        public bool altaLector(string nombre, string dni)
        {
            if (buscarLector(dni) != null)
            {
                return false;
            }

            Lector nuevoLector = new Lector(nombre, dni);
            lectoresRegistrados.Add(nuevoLector);
            return true;
        }

        public string prestarLibro(string titulo, string dni)
        {
            Lector lector = buscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }

            if (lector.getLibrosPrestados() > 2)
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }

            Libro libro = buscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }

            libros.Remove(libro);
            lector.setLibrosPrestados(libro);

            return "PRESTAMO EXITOSO";
        }

    }

}

