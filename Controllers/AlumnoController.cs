using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class AlumnoController : Controller
    {

        [Route("Alumno/Index/")]
        [Route("Alumno/Index/{id}")]
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
            var alumnos = from alum in _context.Alumno
                            where alum.ID == id
                            select alum;

            return View(alumnos.SingleOrDefault());
            }
            else{
                return View("MultiAlumno", _context.Alumno);
            }
        }
        public IActionResult MultiAlumno()
        {
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", _context.Alumno);
        }
         
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context=context;
        }
    }
}