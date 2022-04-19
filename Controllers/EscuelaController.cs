using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            var escuela =_context.Escuelas.FirstOrDefault();
            return View(escuela);  
        }
        public EscuelaController(EscuelaContext context)
        {
            _context=context;
        }
    }
}