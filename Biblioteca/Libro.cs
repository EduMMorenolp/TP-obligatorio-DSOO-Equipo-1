using System;
using System.Threading;

namespace Colecciones
{
    public class Libro
    {
        // Propiedades
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }

        // Constructor
        public Libro(string titulo, string autor, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
        }

        // Metodos
        public string getTitulo()
        {
            return Titulo;
        }

        // Método para mostrar la información del libro
        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Editorial: {Editorial}";
        }
    }
}