using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
