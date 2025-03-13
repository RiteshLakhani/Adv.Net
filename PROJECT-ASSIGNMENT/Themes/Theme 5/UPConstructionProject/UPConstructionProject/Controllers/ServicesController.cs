using Microsoft.AspNetCore.Mvc;

namespace UPConstructionProject.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult ServiceDetails()
        {
            return View();
        }
    }
}
