using System;
using System.Threading;

namespace Colecciones
{
    public class Lector
    {
        private string Nombre { get; set; }
        private string Dni { get; set; }
        public List<Libro> LibrosPrestados { get; set; }

        public Lector(string nombre, string dni)
        {
            Nombre = nombre;
            Dni = dni;
            LibrosPrestados = new List<Libro>();
        }

        public string getDni()
        {
            return Dni;
        }

        public int getLibrosPrestados()
        {
            return LibrosPrestados.Count;
        }

        public void setLibrosPrestados(Libro libro)
        {
            LibrosPrestados.Add(libro);
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Dni: {Dni}, Libros prestados: {LibrosPrestados}";
        }
    }
}