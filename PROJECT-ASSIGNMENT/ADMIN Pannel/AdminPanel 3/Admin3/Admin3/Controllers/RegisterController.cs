using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
