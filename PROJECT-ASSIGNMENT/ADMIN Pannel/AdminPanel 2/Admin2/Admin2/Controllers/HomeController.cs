using Admin2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin2.Controllers
{
    public class HomeController : Controller
    { 

        public IActionResult Index()
        {
            return View();
        }

    }
}
