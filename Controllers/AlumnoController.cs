using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index()
        {
            return View(new Alumnos{Nombre="Humanidades IV",
                                UniqueID=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAlumno()
        {
            var listaAlumnos = GenerarAlumnos();
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", listaAlumnos);
        }
         private List<Alumnos> GenerarAlumnos()
        {
            string[] nombre1 = { "Alondra", "David", "Ricardo", "Itzel", "José", "Aranza", "Isaac", "Isaace" };
            string[] apellido1 = { "Martinez", "Rodriguez", "Gonzalez", "Aguilar", "Lopez", "Maduro", "Bautista", "Gomez" };
            string[] apellido2 = { "Ruiz", "Salas", "Corona", "Hernández", "Juarez", "Jiménez", "Ramírez", "Uribe" };

            //Producto cartesiano de los 3 arreglos. Utilizando LinQ para generar este producto
            //y no utilizar el foreach para la concatenación de los arreglos

            var listaAlumnos = from n1 in nombre1
                               from a1 in apellido1
                               from a2 in apellido2
                               select new Alumnos { Nombre = $"{n1} {a1} {a2}", UniqueID=Guid.NewGuid().ToString()};
                                                    

            return listaAlumnos.OrderBy((al) => al.UniqueID).Take(30).ToList();
        }
    }
}