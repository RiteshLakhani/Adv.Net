using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Models;
using System.Diagnostics;

namespace MyFirstApplication.Controllers
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
    }
}
