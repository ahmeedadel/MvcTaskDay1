using Day1Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day1Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("helloinfo");
        }
    }
}