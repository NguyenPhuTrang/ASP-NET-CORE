using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer(){CustomerId=1, CustomerName="Le Mai",Emai="lemai@gmail.com", Phone="0335110983" },
            new Customer(){CustomerId=2, CustomerName="Mai Hoa",Emai="maihoa@gmail.com", Phone="0775110983" },
        };
        public IActionResult Index()
        {
            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer C)
        {
            try
            {
                if(ModelState.IsValid)
                {
                customers.Add(C);
                return RedirectToAction("Index");
                }
            }
            catch( Exception e)
            {
                ModelState.AddModelError("", "Error : " + e.Message);
            }
            return View(C);
        }
    }
}
