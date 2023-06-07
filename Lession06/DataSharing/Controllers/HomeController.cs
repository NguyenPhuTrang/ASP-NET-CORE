using DataSharing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataSharing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetData()
        {
            List<string> songs = new List<string>()
            {
                "Gio thi anh hua de lam gi",
                "Nguoi yeu cu co nguoi yeu moi",
                "Noi con tim mo coi",
                "Rieng mot goc troi"
            };
            // Cach truye du lieu tu controller xang view
            //1 su dung viewBag
            ViewBag.message1 = "ViewBag la thuoc tinh dong dung de truyen du lieu " +
                "Tu controller sang View. o ben view thi khong can ep kieu." +
                "Khi chuyen huong thi nhan gia tri la Null. ";
            ViewBag.songs = songs;
            //2 . Su dung viewdata
            ViewData["message2"] = "ViewData la thuoc tinh co kieu " +
                " ViewDataDictionary dung de truyen du lieu tu Controller" +
                " Sang View. O ben View thi phai thuc hien ep kieu tuong minh." +
                " Khi chuyen huong thi nhan gia tri la Null .";
            ViewData["song2"] = songs;
            //3. Su dung TempData
            TempData["massage3"] = "TempData la thuoc tinh dung de truyen du lieu" +
                                    " Tu Controller sang View. Khi chuyen huong thi van nhan gia tri";
            //4. Su dung ben trong Model
            // - Ben Controllerr : return View(model)
            // - Ben View :
            // + @model : khai bao model 
            // + @Model : doi tuong chua du lieu nhan duoc tu Controller
            return RedirectToAction("Index", "Home");
            //return View();
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
    }
}
