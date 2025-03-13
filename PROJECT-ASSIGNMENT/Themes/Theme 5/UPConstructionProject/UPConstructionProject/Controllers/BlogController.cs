using Microsoft.AspNetCore.Mvc;

namespace UPConstructionProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
