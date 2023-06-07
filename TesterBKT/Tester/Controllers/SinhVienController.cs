using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tester.Models;

namespace Tester.Controllers
{
    public class SinhVienController : Controller
    {
        List<SinhVien> sinhViens = new List<SinhVien>();
        QLSINHVIENContext _context = new QLSINHVIENContext();
        public IActionResult Index()
        {
            sinhViens = _context.SinhViens.ToList();
            return View(sinhViens);
        }
    }
}
