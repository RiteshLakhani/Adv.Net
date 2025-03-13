using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Generaltables()
        {
            return View();
        }

        public IActionResult Datatables()
        {
            return View();
        }
    }
}
