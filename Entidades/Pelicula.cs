using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Requerido")]
        public string Titulo { get; set; }
        public Genero Genero { get; set; }
        
        /// <summary>
        /// En minutos
        /// </summary>
        public int DuracionMinutos { get; set; }
        public float Calificacion { get; set; }
        public string Sinopsis { get; set; }
    }
}
