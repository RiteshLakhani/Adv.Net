using Microsoft.AspNetCore.Mvc;

namespace ASPCookie.Controllers
{
    public class ASPCookieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
