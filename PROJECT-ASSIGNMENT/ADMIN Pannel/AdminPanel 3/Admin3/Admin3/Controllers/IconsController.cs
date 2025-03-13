using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class IconsController : Controller
    {
        public IActionResult BootStrapIcons()
        {
            return View();
        }

        public IActionResult RemixIcons()
        {
            return View();
        }

        public IActionResult Boxicons()
        {
            return View();
        }
    }
}
