using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace NiceAdmin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FormElements()
        {
            return View();
        }

        public IActionResult FormLayouts()
        {
            return View();
        }

        public IActionResult FormEditiors()
        {
            return View();
        }

        public IActionResult FormValidation()
        {
            return View();
        }
    }
}
