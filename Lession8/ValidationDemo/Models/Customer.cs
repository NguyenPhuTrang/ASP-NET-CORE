using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationDemo.Models
{
    public class Customer
    {

        [Required(ErrorMessage = "Mã khách hàng không được để trống !")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Họ & Tên không được để trống !")]
        [MinLength(5,ErrorMessage ="Họ & tên tối thiểu 5 ký tự !")]
        public string CustomerName { get; set; }
        [EmailAddress(ErrorMessage ="Sai định dạng Email !")]
        public string Emai { get; set; }
        [MinLength(10,ErrorMessage ="Số điện thoại bao gồm 10 chữ số !")]
        public string Phone { get; set; }
    }
}
