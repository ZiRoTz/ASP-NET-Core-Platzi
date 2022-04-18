using ASP_NET_y_GIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_y_GIT.Controllers
{
    public class MateriaController : Controller
    {
        public IActionResult Index()
        {
            var materias= new Materias{
                UniqueID=Guid.NewGuid().ToString(),
                Nombre="Programación"
            };
            ViewBag.Fecha=DateTime.Now;

            return View(materias);
        }
    }
}