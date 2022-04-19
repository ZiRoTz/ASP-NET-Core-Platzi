using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class MateriaController : Controller
    {

        public IActionResult Index()
        {
            return View(new Materias{Nombre="Humanidades IV",
                                ID=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiMateria()
        {
            var listaMaterias = new List<Materias>
                {
                   new Materias{Nombre="Modulación Digital",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Teoría de Control Analógico",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Sistemas Operativos",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Arquitectura de Computadoras",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Ingeniería de Software",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Met. de la Inv. O Top. Selec de la Ing.I",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Probabilidad y Estadística",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Análisis de señales Analógicas",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Análisis de Algoritmos",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Compiladores",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Organización de Computadoras",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Humanidades IV",
                                ID=Guid.NewGuid().ToString()}
                };
            ViewBag.Fecha = DateTime.Now;

            return View("MultiMateria", listaMaterias);
        }
    }
}