using Microsoft.AspNetCore.Mvc;

namespace Lession01.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SayHello()
        {
            return View();
        }
    }
}
