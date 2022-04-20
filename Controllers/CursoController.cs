using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class CursoController : Controller
    {

        /* [Route("Curso/Index/")]
        [Route("Curso/Index/{id}")] */
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
            var grupos = from grup in _context.Grupo
                            where grup.ID == id
                            select grup;

            return View(grupos.SingleOrDefault());
            }
            else{
                return View("MultiCurso", _context.Grupo);
            }
        }
        public IActionResult MultiCurso()
        {
            ViewBag.Fecha = DateTime.Now;

            return View("MultiCurso", _context.Grupo);
        }
         public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }
        [HttpPost]
        public IActionResult Create(Grupos grupos)
        {
            ViewBag.Fecha = DateTime.Now;
            var escuela=_context.Escuelas.FirstOrDefault();
            
            grupos.EscuelaId=escuela.ID;
            _context.Grupo.Add(grupos);
            _context.SaveChanges();


            return View();
        }
        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context=context;
        }
    }
}