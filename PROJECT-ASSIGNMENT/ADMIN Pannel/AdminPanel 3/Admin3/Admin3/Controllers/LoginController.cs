using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
