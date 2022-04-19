using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class MateriaController : Controller
    {

        public IActionResult Index()
        {
            return View(_context.Materia.FirstOrDefault());
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