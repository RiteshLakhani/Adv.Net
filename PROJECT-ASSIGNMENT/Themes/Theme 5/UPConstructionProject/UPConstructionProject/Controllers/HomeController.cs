using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UPConstructionProject.Models;

namespace UPConstructionProject.Controllers
{
    public class HomeController : Controller
    { 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StarterPage()
        {
            return View();
        }
    }
}
