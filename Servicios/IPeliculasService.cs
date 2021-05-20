using Entidades;
using System.Collections.Generic;

namespace Servicios
{
    public interface IPeliculasService
    {
        abstract void Alta(Pelicula p);
        abstract List<Pelicula> Listar();
    }
}