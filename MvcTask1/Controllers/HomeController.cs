using Microsoft.AspNetCore.Mvc;

namespace MvcTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("helloinfo");
        }
    }
}
