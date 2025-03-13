using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class BlankPageController : Controller
    {
        public IActionResult BlankPage()
        {
            return View();
        }
    }
}
