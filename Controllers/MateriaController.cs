using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class MateriaController : Controller
    {
        [Route("Materia/Index/")]
        [Route("Materia/Index/{asignaturaID}")]
        public IActionResult Index(string asignaturaID)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaID))
            {
            var asignatura = from asig in _context.Materia
                            where asig.ID == asignaturaID
                            select asig;

            return View(asignatura.SingleOrDefault());
            }
            else{
                return View("MultiMateria", _context.Materia);
            }
        }
        public IActionResult MultiMateria()
        {
                
            ViewBag.Fecha = DateTime.Now;

            return View("MultiMateria", _context.Materia);
        }
        private EscuelaContext _context;
        public MateriaController(EscuelaContext context)
        {
            _context=context;
        }
    }
}