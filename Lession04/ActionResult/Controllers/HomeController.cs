using ActionResult.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ActionResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public PartialViewResult Index()
        {
            return PartialView("_PartialView");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Cac kieu du lieu tra ve 
        //ContentResult : tra ve 1 chuoi , ham su dung Content ()
        public ContentResult GetContent()
        {
            return Content("Hoc De Thay Doi");
        }
        // RedirectToActionResult : chuyen sang 1 action hoac 1 action cua 1 controller khac
        // Ham su dung la RedirectToAction()

        public RedirectToActionResult RedirectToAnother()
        {
            return RedirectToAction("privacy"); // dan duong khac den privacy
        }
        //RedirectResult : Tra ve 1 url khac, ham su dung Redirect()
        public RedirectResult RedirectURL()
        {
            return Redirect("/Home/privacy"); // dan truc tiep den privacy
        }
        //viewResult : Tra ve 1 view khac de hien thi, ham su dung View()
        public ViewResult GetView()
        {
            return View("privacy");
        }
        //JsonResult : tra ve du lieu dang Json , ham su dung la JSon()
        List<string> flower = new List<string>()
        {
            "V","N","P","T"
        };
        public IActionResult GetJson()
        {
            return Json(flower);
        }
        //Tra ve kieu du lieu nguyen thuy: int, float, ...
        public int CountFlower()
        {
            return flower.Count;
        }
    }
}
