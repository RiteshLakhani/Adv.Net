using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profiles()
        {
            return View();
        }
    }
}
