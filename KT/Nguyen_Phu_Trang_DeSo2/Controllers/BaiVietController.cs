using Microsoft.AspNetCore.Mvc;
using Nguyen_Phu_Trang_DeSo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nguyen_Phu_Trang_DeSo2.Controllers
{
    public class BaiVietController : Controller
    {
        List<BaiViet> baiViets = new List<BaiViet>();
        QLBaiVietContext _context = new QLBaiVietContext();
        public IActionResult Index()
        {
            baiViets = _context.BaiViets.ToList();
            return View(baiViets);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BaiViet baiviet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(baiviet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baiviet);
        }
    }
}

