using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class GenerosService : IGenerosService
    {
        public static List<Genero> Lista = new List<Genero>();
        public GenerosService()
        {
            if (Lista.Count == 0)
            {
                CargarGeneros();
            }
        }

        private static void CargarGeneros()
        {
            Lista.Add(new Genero
            {
                Id = 1,
                Titulo = "Accion"
            });
            Lista.Add(new Genero
            {
                Id = 2,
                Titulo = "Terror"
            });
            Lista.Add(new Genero
            {
                Id = 3,
                Titulo = "Comedia"
            });
            Lista.Add(new Genero
            {
                Id = 4,
                Titulo = "Aventura"
            });
            Lista.Add(new Genero
            {
                Id = 5,
                Titulo = "Suspenso"
            });
            Lista.Add(new Genero
            {
                Id = 6,
                Titulo = "Ciencia Ficcion"
            });
            Lista.Add(new Genero
            {
                Id = 7,
                Titulo = "Drama/Comedia"
            });
            Lista.Add(new Genero
            {
                Id = 8,
                Titulo = "Horror"
            });
            Lista.Add(new Genero
            {
                Id = 9,
                Titulo = "Drama"
            });
        }

        public List<Genero> Listar()
        {
            return Lista.OrderBy(o => o.Titulo).ToList();
        }

        public Genero ObtenerPorId(int id)
        {
            return Lista.FirstOrDefault(o => o.Id == id);
        }

        public Genero ObtenerPorNombre(string titulo)
        {
            return Lista.FirstOrDefault(o => string.Equals(o.Titulo, (titulo ?? "").Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
