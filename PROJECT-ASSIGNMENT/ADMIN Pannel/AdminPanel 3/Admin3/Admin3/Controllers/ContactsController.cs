using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
