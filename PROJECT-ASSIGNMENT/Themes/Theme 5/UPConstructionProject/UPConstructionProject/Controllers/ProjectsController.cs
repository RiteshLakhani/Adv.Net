using Microsoft.AspNetCore.Mvc;

namespace UPConstructionProject.Controllers
{
    public class ProjectsController : Controller
    {
        
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult ProjectsDetails()
        {
            return View();
        }
    }
}
