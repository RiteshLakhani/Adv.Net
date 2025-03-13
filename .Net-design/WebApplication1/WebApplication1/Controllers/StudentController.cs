using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        [Route("Student/Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Student/RL")]
        [Route("Student/R1")]
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
