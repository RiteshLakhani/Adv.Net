using Microsoft.AspNetCore.Mvc;

namespace NiceAdmin.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Chart()
        {
            return View();
        }


        public IActionResult ApexCharts()
        {
            return View();
        }


        public IActionResult ECharts()
        {
            return View();
        }
    }
}
