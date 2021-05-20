using Entidades;
using System.Collections.Generic;

namespace Servicios
{
    public interface IGenerosService
    {
        abstract Genero ObtenerPorNombre(string titulo);
        abstract Genero ObtenerPorId(int id);
        abstract List<Genero> Listar();
    }
}