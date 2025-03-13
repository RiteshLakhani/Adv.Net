using Microsoft.AspNetCore.Mvc;

namespace UPConstructionProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Abouts()
        {
            return View();
        }
    }
}
