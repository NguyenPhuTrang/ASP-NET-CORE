using DataSharing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataSharing.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer(){CustomerId=1, CustomerName=" Trang ", Phone="0335110983"},
            new Customer(){CustomerId=2, CustomerName=" Van ", Phone="08127488173"},
            new Customer(){CustomerId=3, CustomerName=" Tuyen ", Phone="0872463784"}

        };
        public IActionResult Index()
        {
            return View(customers);
        }

    }
}
