using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaEscolar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sistema Académico.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Detalles de contacto.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
