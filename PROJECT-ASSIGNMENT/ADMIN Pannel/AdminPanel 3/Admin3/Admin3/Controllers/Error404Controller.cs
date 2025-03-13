using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class Error404Controller : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
