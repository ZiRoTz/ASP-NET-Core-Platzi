using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index()
        {
            return View(_context.Alumno.FirstOrDefault());
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