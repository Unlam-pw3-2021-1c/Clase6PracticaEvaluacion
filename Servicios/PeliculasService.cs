using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class PeliculasService : IPeliculasService
    {
        private static List<Pelicula> Lista = new List<Pelicula>();

        public PeliculasService()
        {
            if (Lista.Count == 0)
            {
                Lista.Add(
                        new Pelicula
                        {
                            Id= 1,
                            Titulo = "IT",
                            Calificacion = 7,
                            Sinopsis = "",
                            DuracionMinutos = 135,
                            Genero = new Genero()
                            {
                                Id = 2,
                                Titulo= "Terror"
                            }
                        }
                    );
                Lista.Add(
                        new Pelicula
                        {
                            Id = 2,
                            Titulo = "Found",
                            Calificacion = 6,
                            Sinopsis = "",
                            DuracionMinutos = 120,
                            Genero = new Genero()
                            {
                                Id = 8,
                                Titulo = "Horror"
                            }
                        }
                    );
                Lista.Add(
                        new Pelicula
                        {
                            Id = 3,
                            Titulo = "Wonder",
                            Calificacion = 9.6F,
                            Sinopsis = "",
                            DuracionMinutos = 120,
                            Genero = new Genero()
                            {
                                Id = 7,
                                Titulo = "Drama/Comedia"
                            }
                        }
                    );
                Lista.Add(
                        new Pelicula
                        {
                            Id = 4,
                            Titulo = "Hasta el ultimo hombre",
                            Calificacion = 8.1F,
                            Sinopsis = "",
                            DuracionMinutos = 139,
                            Genero = new Genero()
                            {
                                Id = 9,
                                Titulo = "Drama"
                            }
                        }
                    );
            }
        }
        public void Alta(Pelicula p)
        {
            Lista.Add(p);
        }

        public List<Pelicula> Listar()
        {
            return Lista.OrderBy(o => o.Titulo).ToList();
        }
    }
}
