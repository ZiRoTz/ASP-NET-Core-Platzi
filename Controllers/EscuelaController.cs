using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela= new Escuela();
            escuela.añodeCreación = 1997;
            escuela.UniqueID=Guid.NewGuid().ToString();
            escuela.Nombre="ESIME CULHUACAN";
            return View(escuela);
        }
    }
}