using Microsoft.AspNetCore.Mvc;

namespace UPConstructionProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
