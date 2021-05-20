using Entidades;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasePracticaEvaluacion.Controllers
{
    public class PeliculasController : Controller
    {
        IGenerosService generosService;
        IPeliculasService peliculasService;
        public PeliculasController()
        {
            generosService = new GenerosService();
            peliculasService = new PeliculasService();
        }

        public IActionResult Crear()
        {
            ViewData["Generos"] = generosService.Listar();
            return View();
        }

        [HttpPost]  
        public IActionResult Crear(Pelicula p)
        {
            ViewData["Generos"] = generosService.Listar();
            if (!ModelState.IsValid)
                return View(p);
            
            p.Genero = generosService.ObtenerPorId(p.Genero.Id);
            peliculasService.Alta(p);
            TempData["UltPeli"] = JsonConvert.SerializeObject(p);

            //return Redirect($"/?peli={p.Id}");
            return Redirect($"/");
        }

        public IActionResult Listado()
        {
            return View(peliculasService.Listar());
        }
    }
}
