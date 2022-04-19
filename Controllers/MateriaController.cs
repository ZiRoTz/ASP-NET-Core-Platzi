using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class MateriaController : Controller
    {

        public IActionResult Index()
        {
            return View(new Materias{Nombre="Humanidades IV",
                                UniqueID=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiMateria()
        {
            var listaMaterias = new List<Materias>
                {
                   new Materias{Nombre="Modulación Digital",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Teoría de Control Analógico",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Sistemas Operativos",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Arquitectura de Computadoras",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Ingeniería de Software",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Met. de la Inv. O Top. Selec de la Ing.I",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Probabilidad y Estadística",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Análisis de señales Analógicas",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Análisis de Algoritmos",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Compiladores",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Organización de Computadoras",
                                UniqueID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Humanidades IV",
                                UniqueID=Guid.NewGuid().ToString()}
                };
            ViewBag.Fecha = DateTime.Now;

            return View("MultiMateria", listaMaterias);
        }
    }
}