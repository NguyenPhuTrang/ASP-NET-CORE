using Microsoft.AspNetCore.Mvc;
using NguyenPhuTrang_Deso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenPhuTrang_Deso2.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>()
        {
            new Member(){ MemberId="001", Username="Duc", Password="duc01",Age=20,Email="NPt@gmail.com" },
            new Member(){ MemberId="002", Username="Van", Password="van01",Age=21,Email="Nct@gmail.com" },
            new Member(){ MemberId="003", Username="Tuyen", Password="tuyen01",Age=22,Email="Nvt@gmail.com" },
            new Member(){ MemberId="004", Username="Thanh", Password="thanh01",Age=23,Email="Nmt@gmail.com" },
            new Member(){ MemberId="005", Username="Khanh", Password="khanh01",Age=24,Email="Nct@gmail.com" },
        };
        public IActionResult Index()
        {
            return View(members);
        }
        public IActionResult add()
        {
            return View(members);
        }
        public IActionResult Save(Member member)
        {
            members.Add(member);
            return RedirectToAction("Index");
        }
        public IActionResult delete(Member mb)
        {
            var DeleteMb = members.SingleOrDefault(e => e.MemberId == mb.MemberId);
            members.Remove(DeleteMb);
            return RedirectToAction("Index"); ;

        }
    }
}
