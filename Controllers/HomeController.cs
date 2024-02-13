using Microsoft.AspNetCore.Mvc;
using Mission06_Ross.Models;
using System.Diagnostics;

namespace Mission06_Ross.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult AddMovie()
        {
            return View();
        }
    }
}
