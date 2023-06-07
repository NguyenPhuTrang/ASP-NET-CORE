using List_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Student.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> sinhvien = new List<Student>()
        {
            new Student(){MaSv="sv01",HoTen="hoang duc van",DiaChi="Thái bình"},
            new Student(){MaSv="sv02",HoTen="nguyen thuy duc",DiaChi="nghệ an"},
            new Student(){MaSv="sv03",HoTen="Nguyễn Phú Trang",DiaChi="quốc oai"},
            new Student(){MaSv="sv4",HoTen="Hoàng Văn Tuyển",DiaChi="hà nội"}
        };
        public IActionResult Index()
        {

            return View(sinhvien);
        }
        public IActionResult Add()
        {

            return View(sinhvien);
        }
        //Tiep Nhan tham so : gom cac cach sau 
        //1 . Su dung Request
        //public IActionResult Save()
        //{
        //    Student st = new Student();
        //    st.MaSv = Request.Form["MaSv"];
        //    st.HoTen = Request.Form["HoTen"];
        //    st.DiaChi = Request.Form["DiaChi"];
        //    sinhvien.Add(st);
        //    return RedirectToAction("Index");

        //}

        //2. su dung IFormCollection
        //public IActionResult Save(IFormCollection form)
        //{
        //    Student student = new Student();
        //    student.MaSv = form["MaSv"];
        //    student.HoTen = form["HoTen"];
        //    student.DiaChi = form["DiaChi"];
        //    sinhvien.Add(student);
        //    return RedirectToAction("Index");

        //}

        //3. Su dung doi so action , chi nhan cac tham so trung ten
        public IActionResult Save(string maSV, string hoTen, string diaChi)
        {
            Student student = new Student();
            student.MaSv = maSV;
            student.HoTen = hoTen;
            student.DiaChi = diaChi;
            sinhvien.Add(student);
            return RedirectToAction("Index");
        }
        //4. Su dung Model 
        //- Tao model chua cac thuoc tinh trung ten voi ten cau cac tham so 
        //- Su dung model la doi so cua action de nhan cac thm so tu ten 
        //[ActionName("Store")]
        public IActionResult Save(Student students)
        {
            sinhvien.Add(students);
            return RedirectToAction("Index");
        }
    }
}
